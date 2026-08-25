using System.Runtime.InteropServices;
using piko.Generator.Bindings;

namespace piko.Generator;

public class TypeTransformer(TypeTransformer.Options options)
{
    private Options _options = options;

    private readonly Dictionary<string, StructBinding> _structs = new();

    private readonly Dictionary<string, EnumBinding> _newEnums = new();

    public void Transform(ref BindingsSet bindings)
    {
        foreach (StructBinding s in bindings.Structs)
        {
            if (s.Fields.Count == 0 && _options.EmptyStructsAreHandleTypes && s.Layout != LayoutKind.Explicit)
                s.IsHandleType = true;

            _structs.Add(s.Name, s);
        }

        foreach (ConstantBinding c in bindings.Constants)
            TransformConstant(c);

        foreach (StructBinding s in bindings.Structs)
            TransformStruct(s);

        foreach (FunctionBinding f in bindings.Functions)
            TransformFunction(f);

        foreach (FunctionBinding d in bindings.Delegates)
            TransformFunction(d);

        foreach ((_, EnumBinding e) in _newEnums)
            bindings.Enums.Add(e);
    }

    private void TransformConstant(ConstantBinding c)
    {
        int zero = 0;
        c.Type = GetCorrectedType(c.Type, null, ref zero, false);

        if (c.Type == "string" && c.Value.EndsWith("u8"))
            c.Value = c.Value.Substring(0, c.Value.Length - 2);

        if (_options.AssociateConstantPrefixWithType != null)
        {
            foreach ((string prefix, ConstantType type) in _options.AssociateConstantPrefixWithType)
            {
                if (c.Prefix != prefix)
                    continue;

                switch (type.TypeToGenerate)
                {
                    case GenerateType.StaticClass:
                        c.ClassName = type.TypeName;
                        break;
                    case GenerateType.Enum:
                    case GenerateType.FlagsEnum:
                    {
                        if (!_newEnums.TryGetValue(type.TypeName, out EnumBinding binding))
                        {
                            // need to remap some types such as nuint as enums can't be of that type
                            string enumType = type.EnumType ?? c.Type switch
                            {
                                "nuint" => "ulong",
                                _ => c.Type
                            };

                            binding = new EnumBinding(type.TypeName, enumType)
                            {
                                IsFlagsEnum = type.TypeToGenerate == GenerateType.FlagsEnum
                            };
                            _newEnums.Add(type.TypeName, binding);
                        }

                        binding.Values.Add(new EnumBinding.EnumValue(c.Name, c.Value));
                        c.SkipGenerationInMainClass = true;

                        break;
                    }
                }
            }
        }
    }

    private void TransformStruct(StructBinding s)
    {
        foreach (StructBinding.Field field in s.Fields)
            field.Type = GetCorrectedType(field.Type, field.NativeType, ref field.PointerLevel, true);
    }

    private void TransformFunction(FunctionBinding f)
    {
        bool isBoolRemapEnabled = _options.BytesAreBooleansByDefault;
        if (_options.FunctionRemapping.TryGetValue(f.PInvokeName, out FunctionRemap remap))
        {
            if (remap.BytesAreBooleans is bool bytesAreBooleans)
                _options.BytesAreBooleansByDefault = bytesAreBooleans;
        }

        if (f.ReturnType != null)
            f.ReturnType = GetCorrectedType(f.ReturnType, f.ReturnTypeNativeType, ref f.ReturnTypePointerLevel, false);

        foreach (FunctionBinding.Parameter parameter in f.Parameters)
            parameter.Type = GetCorrectedType(parameter.Type, parameter.NativeType, ref parameter.PointerLevel, false, true, ref parameter.FlowDirection);

        _options.BytesAreBooleansByDefault = isBoolRemapEnabled;
    }

    private string GetCorrectedType(string type, string? nativeType, ref int pointerLevel, bool isStruct, bool isParameter, ref PointerFlowDirection flowDirection)
    {
        // if the field's type is a handle type, don't generate a pointer for it.
        if (_structs.TryGetValue(type, out StructBinding fieldStruct) && fieldStruct.IsHandleType)
            pointerLevel--;

        // naive way of checking if the type we're transforming has been manually remapped to a handle type
        // todo see if there's a better way to do this rather than looping through every remapped type
        foreach ((_, TypeRemap remap) in _options.TypeRemapping)
        {
            if (remap.Name == type && remap.IsHandleType)
                pointerLevel--;
        }

        if (nativeType != null)
        {
            switch (nativeType)
            {
                case "bool":
                    type = "bool";
                    break;
            }
        }

        if (pointerLevel > 0)
        {
            switch (type)
            {
                case "void":
                    return "nint";
            }
        }

        if (!isStruct)
        {
            switch (type)
            {
                case "sbyte" when pointerLevel == 1:
                    return "string";
                case "byte" when _options.BytesAreBooleansByDefault && pointerLevel == 0:
                    return "bool";
                case "ReadOnlySpan<byte>":
                    return "string";
            }
        }

        /*if (flowDirection == PointerFlowDirection.None && isParameter && pointerLevel > 0)
        {
            switch (type)
            {
                case "void":
                case "sbyte":
                //case "byte":
                //case "short":
                //case "ushort":
                //case "int":
                //case "uint":
                //case "long":
                //case "ulong":
                    break;
                default:
                    flowDirection = PointerFlowDirection.InAndOut;
                    pointerLevel--;
                    break;
            }
        }*/

        string newType = type;
        for (int i = 0; i < pointerLevel; i++)
            newType += '*';

        return newType;
    }

    private string GetCorrectedType(string type, string? nativeType, ref int pointerLevel, bool isStruct)
    {
        PointerFlowDirection none = PointerFlowDirection.None;
        return GetCorrectedType(type, nativeType, ref pointerLevel, isStruct, false, ref none);
    }

    public struct Options
    {
        /// <summary>
        /// If true, empty structs will be transformed to a special "handle" type.
        /// </summary>
        public bool EmptyStructsAreHandleTypes;

        /// <summary>
        /// If enabled, byte values will be generated as booleans unless manually specified
        /// </summary>
        public bool BytesAreBooleansByDefault;

        /// <summary>
        /// Associate a constant prefix (key) with a type (value).
        /// </summary>
        public Dictionary<string, ConstantType> AssociateConstantPrefixWithType;

        public Dictionary<string, TypeRemap> TypeRemapping;

        public Dictionary<string, FunctionRemap> FunctionRemapping;
    }

    public struct ConstantType
    {
        /// <summary>
        /// The name of the type.
        /// </summary>
        public string TypeName;

        /// <summary>
        /// The type that should be generated.
        /// </summary>
        public GenerateType TypeToGenerate;

        /// <summary>
        /// The type of an enum. If not provided, a value will be auto-determined, which may not always be correct.
        /// </summary>
        public string? EnumType;

        public ConstantType(string typeName, GenerateType typeToGenerate)
        {
            TypeName = typeName;
            TypeToGenerate = typeToGenerate;
        }
    }

    public enum GenerateType
    {
        /// <summary>
        /// Generate a static class.
        /// </summary>
        StaticClass,

        /// <summary>
        /// Generate a non-flags enum.
        /// </summary>
        Enum,

        /// <summary>
        /// Generate a flags enum.
        /// </summary>
        FlagsEnum
    }

    public struct TypeRemap
    {
        public string Name;

        public bool IsHandleType;

        public TypeRemap(string name, bool isHandleType)
        {
            Name = name;
            IsHandleType = isHandleType;
        }
    }

    public struct FunctionRemap
    {
        /// <summary>
        /// Remap bytes as booleans. This overrides the default setting if set.
        /// </summary>
        public bool? BytesAreBooleans;
    }
}
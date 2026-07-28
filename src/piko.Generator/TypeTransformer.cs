using piko.Generator.Bindings;

namespace piko.Generator;

public class TypeTransformer(TypeTransformer.Options options)
{
    private readonly Dictionary<string, StructBinding> _structs = new();

    private readonly Dictionary<string, EnumBinding> _newEnums = new();

    public void Transform(ref BindingsSet bindings)
    {
        foreach (StructBinding s in bindings.Structs)
        {
            if (s.Fields.Count == 0 && options.EmptyStructsAreHandleTypes)
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
        c.Type = GetCorrectedType(c.Type, null, 0, false);

        if (c.Type == "string" && c.Value.EndsWith("u8"))
            c.Value = c.Value.Substring(0, c.Value.Length - 2);

        if (options.AssociateConstantPrefixWithType != null)
        {
            foreach ((string prefix, ConstantType type) in options.AssociateConstantPrefixWithType)
            {
                if (c.Prefix != prefix)
                    continue;

                if (type.IsFlagsEnum)
                {
                    if (!_newEnums.TryGetValue(type.TypeName, out EnumBinding binding))
                    {
                        // need to remap some types such as nuint as enums can't be of that type
                        string enumType = c.Type switch
                        {
                            "nuint" => "ulong",
                            _ => c.Type
                        };

                        binding = new EnumBinding(type.TypeName, enumType)
                        {
                            IsFlagsEnum = true
                        };
                        _newEnums.Add(type.TypeName, binding);
                    }

                    binding.Values.Add(new EnumBinding.EnumValue(c.Name, c.Value));
                    c.SkipGenerationInMainClass = true;
                }
                else
                    c.ClassName = type.TypeName;
            }
        }
    }

    private void TransformStruct(StructBinding s)
    {
        foreach (StructBinding.Field field in s.Fields)
            field.Type = GetCorrectedType(field.Type, field.NativeType, field.PointerLevel, true);
    }

    private void TransformFunction(FunctionBinding f)
    {
        if (f.ReturnType != null)
            f.ReturnType = GetCorrectedType(f.ReturnType, f.ReturnTypeNativeType, f.ReturnTypePointerLevel, false);

        foreach (FunctionBinding.Parameter parameter in f.Parameters)
            parameter.Type = GetCorrectedType(parameter.Type, parameter.NativeType, parameter.PointerLevel, false);
    }

    private string GetCorrectedType(string type, string? nativeType, int pointerLevel, bool isStruct)
    {
        // if the field's type is a handle type, don't generate a pointer for it.
        if (_structs.TryGetValue(type, out StructBinding fieldStruct) && fieldStruct.IsHandleType)
            return type;

        if (nativeType != null)
        {
            switch (nativeType)
            {
                case "bool":
                    type = "bool";
                    break;
            }
        }

        if (!isStruct)
        {
            switch (type)
            {
                case "sbyte" when pointerLevel == 1:
                    return "string";
                case "ReadOnlySpan<byte>":
                    return "string";
            }
        }

        string newType = type;
        for (int i = 0; i < pointerLevel; i++)
            newType += '*';

        return newType;
    }

    public struct Options
    {
        /// <summary>
        /// If true, empty structs will be transformed to a special "handle" type.
        /// </summary>
        public bool EmptyStructsAreHandleTypes;

        /// <summary>
        /// Associate a constant prefix (key) with a type (value).
        /// </summary>
        public Dictionary<string, ConstantType> AssociateConstantPrefixWithType;
    }

    public struct ConstantType
    {
        /// <summary>
        /// The name of the type.
        /// </summary>
        public string TypeName;

        /// <summary>
        /// If true, a flags enum will be generated. Otherwise, a static class will be generated.
        /// </summary>
        public bool IsFlagsEnum;

        public ConstantType(string typeName, bool isFlagsEnum)
        {
            TypeName = typeName;
            IsFlagsEnum = isFlagsEnum;
        }
    }
}
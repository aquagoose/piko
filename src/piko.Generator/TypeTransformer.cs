using piko.Generator.Bindings;

namespace piko.Generator;

public class TypeTransformer(TypeTransformer.Options options)
{
    private readonly Dictionary<string, StructBinding> _structs = new();

    public void Transform(ref BindingsSet bindings)
    {
        foreach (StructBinding s in bindings.Structs)
        {
            if (s.Fields.Count == 0 && options.EmptyStructsAreHandleTypes)
                s.IsHandleType = true;

            _structs.Add(s.Name, s);
        }

        foreach (StructBinding s in bindings.Structs)
            TransformStruct(s);

        foreach (FunctionBinding f in bindings.Functions)
            TransformFunction(f);
    }

    private void TransformStruct(StructBinding s)
    {
        foreach (StructBinding.Field field in s.Fields)
            field.Type = GetCorrectedType(field.Type, field.NativeType, field.PointerLevel, true);
    }

    private void TransformFunction(FunctionBinding f)
    {
        if (f.ReturnType != null)
            f.ReturnType = GetCorrectedType(f.ReturnType, null, f.ReturnTypePointerLevel, false);

        foreach (FunctionBinding.Parameter parameter in f.Parameters)
            parameter.Type = GetCorrectedType(parameter.Type, null, parameter.PointerLevel, false);
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
    }
}
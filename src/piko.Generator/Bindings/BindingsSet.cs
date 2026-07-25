namespace piko.Generator.Bindings;

public record BindingsSet
{
    public List<EnumBinding> Enums;
    public List<StructBinding> Structs;
    public List<FunctionBinding> Functions;

    public BindingsSet()
    {
        Enums = [];
        Structs = [];
        Functions = [];
    }
}
namespace piko.Generator.Bindings;

public record BindingsSet
{
    public List<EnumBinding> Enums;
    public List<ConstantBinding> Constants;
    public List<StructBinding> Structs;
    public List<FunctionBinding> Functions;
    public List<FunctionBinding> Delegates;

    public BindingsSet()
    {
        Enums = [];
        Constants = [];
        Structs = [];
        Functions = [];
        Delegates = [];
    }
}
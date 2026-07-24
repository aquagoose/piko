namespace piko.Generator.Bindings;

public record BindingsSet
{
    public List<EnumBinding> Enums;

    public BindingsSet()
    {
        Enums = [];
    }
}
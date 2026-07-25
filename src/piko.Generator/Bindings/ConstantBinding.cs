namespace piko.Generator.Bindings;

public record ConstantBinding
{
    /// <summary>
    /// The constant's name.
    /// </summary>
    public string Name;

    /// <summary>
    /// The constant's type.
    /// </summary>
    public string Type;

    /// <summary>
    /// The constant's value.
    /// </summary>
    public string Value;

    public ConstantBinding(string name, string type, string value)
    {
        Name = name;
        Type = type;
        Value = value;
    }
}

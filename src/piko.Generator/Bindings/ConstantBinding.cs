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

    /// <summary>
    /// The original unchanged name.
    /// </summary>
    public string? Prefix;

    /// <summary>
    /// If true, this means that the constant will be generated elsewhere, and should not be generated in the main method class.
    /// </summary>
    public bool SkipGenerationInMainClass;

    public ConstantBinding(string name, string type, string value)
    {
        Name = name;
        Type = type;
        Value = value;
    }
}

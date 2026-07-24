namespace piko.Generator.Bindings;

public record EnumBinding
{
    /// <summary>
    /// The name of the enum.
    /// </summary>
    public string Name;

    /// <summary>
    /// The primitive type.
    /// </summary>
    public string? Type;

    /// <summary>
    /// The values contained in this enum.
    /// </summary>
    public List<EnumValue> Values;

    public EnumBinding()
    {
        Name = string.Empty;
        Type = null;
        Values = [];
    }

    public record EnumValue
    {
        /// <summary>
        /// The value's name.
        /// </summary>
        public string Name;

        /// <summary>
        /// The value itself. This is usually an integer, but can be a string to refer to a previous enum value.
        /// </summary>
        public string? Value;

        public EnumValue(string name, string? value)
        {
            Name = name;
            Value = value;
        }
    }
}
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
    /// If true, the enum is a bitflags enum.
    /// </summary>
    public bool IsFlagsEnum;

    /// <summary>
    /// The values contained in this enum.
    /// </summary>
    public List<EnumValue> Values;

    public EnumBinding(string name, string? type)
    {
        Name = name;
        Type = type;
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
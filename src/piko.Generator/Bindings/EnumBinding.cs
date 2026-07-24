namespace piko.Generator.Bindings;

public struct EnumBinding
{
    /// <summary>
    /// The name of the enum.
    /// </summary>
    public string Name;

    /// <summary>
    /// The primitive type.
    /// </summary>
    public string Type;

    public struct EnumValue
    {
        /// <summary>
        /// The value's name.
        /// </summary>
        public string Name;

        /// <summary>
        /// The value itself. This is usually an integer, but can be a string to refer to a previous enum value.
        /// </summary>
        public string Value;
    }
}
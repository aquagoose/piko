using System.Runtime.InteropServices;

namespace piko.Generator.Bindings;

public record StructBinding
{
    /// <summary>
    /// The struct's name.
    /// </summary>
    public string Name;

    /// <summary>
    /// The struct's layout.
    /// </summary>
    public LayoutKind Layout;

    /// <summary>
    /// The struct fields.
    /// </summary>
    public List<Field> Fields;

    public StructBinding(string name, LayoutKind layout)
    {
        Name = name;
        Layout = layout;
        Fields = [];
    }

    public record Field
    {
        /// <summary>
        /// The field name.
        /// </summary>
        public string Name;

        /// <summary>
        /// Its type.
        /// </summary>
        public string Type;

        /// <summary>
        /// The pointer level of the type. Type* will be 1, Type** will be 2, etc.
        /// </summary>
        public int PointerLevel;

        /// <summary>
        /// The field offset, if applicable.
        /// </summary>
        public int Offset;

        public Field(string name, string type, int pointerLevel, int offset)
        {
            Name = name;
            Type = type;
            PointerLevel = pointerLevel;
            Offset = offset;
        }
    }
}
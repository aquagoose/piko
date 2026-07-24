namespace piko.Generator.Bindings;

public record FunctionBinding
{
    /// <summary>
    /// The function name.
    /// </summary>
    public string Name;

    /// <summary>
    /// The name to use in DllImport/LibraryImport.
    /// </summary>
    public string PInvokeName;

    /// <summary>
    /// The return type, if any.
    /// </summary>
    public string? ReturnType;

    /// <summary>
    /// The pointer level of the return type. Type* will be 1, Type** will be 2, etc.
    /// </summary>
    public int ReturnTypePointerLevel;

    /// <summary>
    /// The parameter list.
    /// </summary>
    public List<Parameter> Parameters;

    public FunctionBinding(string name, string pInvokeName, string? returnType, int returnTypePointerLevel)
    {
        Name = name;
        PInvokeName = pInvokeName;
        ReturnType = returnType;
        ReturnTypePointerLevel = returnTypePointerLevel;
        Parameters = [];
    }

    public record Parameter
    {
        /// <summary>
        /// The parameter name.
        /// </summary>
        public string Name;

        /// <summary>
        /// The parameter type.
        /// </summary>
        public string Type;

        /// <summary>
        /// The pointer level of this parameter. Type* will be 1, Type** will be 2, etc.
        /// </summary>
        public int PointerLevel;

        public Parameter(string name, string type, int pointerLevel)
        {
            Name = name;
            Type = type;
            PointerLevel = pointerLevel;
        }
    }
}
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
    /// The native type of the return type, if applicable.
    /// </summary>
    public string? ReturnTypeNativeType;

    /// <summary>
    /// The pointer level of the return type. Type* will be 1, Type** will be 2, etc.
    /// </summary>
    public int ReturnTypePointerLevel;

    /// <summary>
    /// The parameter list.
    /// </summary>
    public List<Parameter> Parameters;

    public FunctionBinding(string name, string pInvokeName, string? returnType, string? returnTypeNativeType, int returnTypePointerLevel)
    {
        Name = name;
        PInvokeName = pInvokeName;
        ReturnType = returnType;
        ReturnTypeNativeType = returnTypeNativeType;
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
        /// The native type, if applicable.
        /// </summary>
        public string? NativeType;

        /// <summary>
        /// The pointer level of this parameter. Type* will be 1, Type** will be 2, etc.
        /// </summary>
        public int PointerLevel;

        public Parameter(string name, string type, string? nativeType, int pointerLevel)
        {
            Name = name;
            Type = type;
            NativeType = nativeType;
            PointerLevel = pointerLevel;
        }
    }
}
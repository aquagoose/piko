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
    /// The parameter list.
    /// </summary>
    public List<Parameter> Parameters;

    public FunctionBinding(string name, string pInvokeName, string? returnType)
    {
        Name = name;
        PInvokeName = pInvokeName;
        ReturnType = returnType;
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

        public Parameter(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
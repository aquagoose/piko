namespace piko.Generator.Configs;

public class PikoGeneratorConfig
{
    /// <summary>
    /// The output directory to write files into.
    /// </summary>
    public string OutputDirectory;

    /// <summary>
    /// The namespace to apply to all output types.
    /// </summary>
    public string Namespace;

    /// <summary>
    /// The name of the library's DLL, for example "SDL3".
    /// You should not include a file extension as the .NET runtime will detect this automatically,
    /// and doing so would prevent the generated library from being crossplatform.
    /// </summary>
    public string LibraryDllName;

    /// <summary>
    /// The name of the class containing the function bindings, and unmapped constants.
    /// </summary>
    public string MethodClassName;

    /// <summary>
    /// The prefix to strip from all names, for example "SDL_".
    /// This applies to ALL names, including type names, enumerators, and functions.
    /// </summary>
    public string PrefixToStrip;

    /// <summary>
    /// The name of the analyzer to use.
    /// There are two built-in analyzers.
    ///     - ClangSharp
    ///     - KhronosXml
    /// </summary>
    public string Analyzer;

    /// <summary>
    /// Specify type names to manually remap. This includes typedefs, which are not automatically remapped.
    /// </summary>
    public Dictionary<string, TypeTransformer.TypeRemap> TypeRemapping;

    /// <summary>
    /// Defines the configuration for enums.
    /// </summary>
    public EnumsConfig Enums;

    /// <summary>
    /// Defines the configuration for constants.
    /// </summary>
    public ConstantsConfig Constants;

    /// <summary>
    /// Defines the configuration for the generator.
    /// </summary>
    public GeneratorConfig Generator;

    /// <summary>
    /// Defines the configuration for ClangSharp. NOTE: This MUST be present if the ClangSharp analyzer is used.
    /// </summary>
    public ClangSharpConfig? ClangSharp;
}
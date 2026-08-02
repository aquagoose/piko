namespace piko.Generator.Configs;

public class GeneratorConfig
{
    public bool UseLibraryImport;
    public bool EmptyStructsAreHandleTypes;
    public bool HandleTypesUseIHandleInterface;
    public bool AllTypesAreSubTypes;
    public bool AllStringsAreUTF8;
    public Dictionary<string, string> CustomReturnValueTypeMarshallers;
}
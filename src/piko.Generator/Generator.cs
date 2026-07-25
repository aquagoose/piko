using System.Text;
using piko.Generator.Bindings;

namespace piko.Generator;

public class Generator(BindingsSet bindings, string methodClassName, Generator.Options options)
{
    private readonly StringBuilder _sb = new();

    public Output[] Generate()
    {
        List<Output> outputs = [];

        foreach (EnumBinding e in bindings.Enums)
            outputs.Add(new Output(e.Name, WriteEnum(e)));

        _sb.Clear();
        _sb.AppendLine($"public static unsafe partial class {methodClassName}");
        _sb.AppendLine("{");
        _sb.AppendLine($"    public const string LibraryName = \"{options.LibraryDllName}\";");
        foreach (FunctionBinding f in bindings.Functions)
            WriteFunction(f);
        _sb.AppendLine("}");
        outputs.Add(new Output(methodClassName, _sb.ToString()));

        return outputs.ToArray();
    }

    private string WriteEnum(EnumBinding e)
    {
        _sb.Clear();

        _sb.Append($"public enum {e.Name}");
        if (e.Type != null)
            _sb.Append($" : {e.Type}");
        _sb.AppendLine();
        _sb.AppendLine("{");

        foreach (EnumBinding.EnumValue value in e.Values)
        {
            _sb.Append(' ', 4);
            _sb.Append(value.Name);
            if (value.Value != null)
                _sb.Append($" = {value.Value}");
            _sb.AppendLine(",");
        }

        _sb.AppendLine("}");
        string output = _sb.ToString();
        return WriteExtraStuff(output);
    }

    private string WriteFunction(FunctionBinding f)
    {
        // todo IMPORTANT auto generate marshalling stuff and use LibraryImport!!
        _sb.AppendLine($"    [DllImport(LibraryName, EntryPoint = \"{f.PInvokeName}\", ExactSpelling = true)]");

        _sb.Append($"    public extern {f.ReturnType ?? "void"} {f.Name}(");

        int i = 0;
        foreach (FunctionBinding.Parameter parameter in f.Parameters)
        {
            _sb.Append(parameter.Type);
            _sb.Append(' ');
            _sb.Append(parameter.Name);
            if (++i < f.Parameters.Count)
                _sb.Append(", ");
        }

        _sb.AppendLine(");");
        _sb.AppendLine();
        return _sb.ToString();
    }

    private string WriteExtraStuff(string str)
    {
        _sb.Clear();

        if (options.AllTypesAreSubTypes)
        {
            _sb.AppendLine($"public static unsafe partial class {methodClassName}");
            _sb.AppendLine("{");
            _sb.Append(' ', 4);
            _sb.AppendLine(str.Replace("\n", "\n    "));
            _sb.AppendLine("}");
        }

        return _sb.ToString();
    }

    public struct Output
    {
        public string TypeName;
        public string Code;

        public Output(string typeName, string code)
        {
            TypeName = typeName;
            Code = code;
        }
    }

    public struct Options
    {
        /// <summary>
        /// The name of the library DLL name, for example "SDL3".
        /// </summary>
        public string LibraryDllName;

        /// <summary>
        /// If true, all types such as enums and structs, will be a subtype of the method class.
        /// For example, if the method class is "SDL", then this will generate types "SDL.Window" etc.
        /// instead of "Window".
        /// </summary>
        public bool AllTypesAreSubTypes;
    }
}
using System.Runtime.InteropServices;
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

        foreach (StructBinding s in bindings.Structs)
            outputs.Add(new Output(s.Name, WriteStruct(s)));

        _sb.Clear();
        _sb.AppendLine($"public static unsafe partial class {methodClassName}");
        _sb.AppendLine("{");
        _sb.AppendLine($"    public const string LibraryName = \"{options.LibraryDllName}\";");
        _sb.AppendLine();
        foreach (ConstantBinding c in bindings.Constants)
            WriteConstant(c);
        _sb.AppendLine();
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

        _sb.Append('}');
        string output = _sb.ToString();
        return WriteExtraStuff(output);
    }

    private string WriteStruct(StructBinding s)
    {
        _sb.Clear();

        _sb.AppendLine($"[StructLayout(LayoutKind.{s.Layout})]"); // we can directly print the enum as we are using the same enum
        _sb.AppendLine($"public unsafe struct {s.Name}");
        _sb.AppendLine("{");

        if (s.Fields.Count == 0)
        {
            _sb.AppendLine($$"""
                                 private readonly nint _handle;

                                 public nint Handle => _handle;
                                 public bool IsNull => _handle == 0;

                                 public {{s.Name}}(nint handle)
                                 {
                                     _handle = handle;
                                 }
                             
                                 public static implicit operator bool({{s.Name}} s)
                                      => !s.IsNull;
                             """);
        }
        else
        {
            foreach (StructBinding.Field field in s.Fields)
            {
                _sb.Append(' ', 4);

                if (s.Layout == LayoutKind.Explicit)
                    _sb.Append($"[FieldOffset({field.Offset})] ");
                _sb.AppendLine($"public {field.Type} {field.Name};");
            }

            _sb.AppendLine();

            // generate constructor
            _sb.Append($"    public {s.Name}(");
            int i = 0;
            foreach (StructBinding.Field field in s.Fields)
            {
                _sb.Append(field.Type);
                _sb.Append(' ');
                // this sure is a way of all time to convert the first character to lower case to make it a suitable parameter name
                _sb.Append(char.ToLowerInvariant(field.Name[0]));
                _sb.Append(field.Name[1..]);
                if (++i < s.Fields.Count)
                    _sb.Append(", ");
            }
            _sb.AppendLine(")");
            _sb.AppendLine("    {");

            foreach (StructBinding.Field field in s.Fields)
            {
                _sb.Append(' ', 8);
                _sb.Append("this.");
                _sb.Append(field.Name);
                _sb.Append(" = ");
                _sb.Append(char.ToLowerInvariant(field.Name[0]));
                _sb.Append(field.Name[1..]);
                _sb.AppendLine(";");
            }

            _sb.AppendLine("    }");
        }

        _sb.Append('}');
        string output = _sb.ToString();
        return WriteExtraStuff(output);
    }

    private void WriteConstant(ConstantBinding c)
    {
        _sb.AppendLine($"    public const {c.Type} {c.Name} = {c.Value};");
    }

    private void WriteFunction(FunctionBinding f)
    {
        _sb.AppendLine($"    [LibraryImport(LibraryName, EntryPoint = \"{f.PInvokeName}\")]");

        string returnType = f.ReturnType ?? "void";
        if (GetMarshalInfoIfNeeded(returnType) is string returnMarshal)
            _sb.AppendLine($"    [return: {returnMarshal}]");

        _sb.Append($"    public static partial {returnType} {f.Name}(");

        int i = 0;
        foreach (FunctionBinding.Parameter parameter in f.Parameters)
        {
            if (GetMarshalInfoIfNeeded(parameter.Type) is string parameterMarshal)
                _sb.Append($"[{parameterMarshal}] ");

            _sb.Append(parameter.Type);
            _sb.Append(' ');
            _sb.Append(parameter.Name);
            if (++i < f.Parameters.Count)
                _sb.Append(", ");
        }

        _sb.AppendLine(");");
        _sb.AppendLine();
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

    private string? GetMarshalInfoIfNeeded(string type)
    {
        return type switch
        {
            "bool" => "MarshalAs(UnmanagedType.I1)",
            "string" => "MarshalAs(UnmanagedType.LPStr)",
            _ => null
        };
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
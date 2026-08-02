using System.Runtime.InteropServices;
using System.Text;
using piko.Generator.Bindings;

namespace piko.Generator;

public class Generator(BindingsSet bindings, string methodClassName, Generator.Options options)
{
    private readonly StringBuilder _sb = new();
    private readonly Dictionary<string, List<ConstantBinding>> _constantTypes = new();

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
            WriteConstant(c, false);
        _sb.AppendLine();
        foreach (FunctionBinding f in bindings.Functions)
            WriteFunction(f);
        _sb.AppendLine();
        foreach (FunctionBinding d in bindings.Delegates)
            WriteDelegate(d);
        _sb.AppendLine("}");
        outputs.Add(new Output(methodClassName, _sb.ToString()));

        foreach ((string typeName, List<ConstantBinding> constants) in _constantTypes)
        {
            _sb.Clear();
            _sb.AppendLine($"public static unsafe partial class {typeName}");
            _sb.AppendLine("{");
            foreach (ConstantBinding c in constants)
                WriteConstant(c, true);
            _sb.AppendLine("}");
            string output = WriteExtraStuff(_sb.ToString());
            outputs.Add(new Output(typeName, output));
        }

        return outputs.ToArray();
    }

    private string WriteEnum(EnumBinding e)
    {
        _sb.Clear();

        if (e.IsFlagsEnum)
            _sb.AppendLine("[Flags]");

        _sb.Append($"public enum {e.Name}");
        if (e.Type != null)
            _sb.Append($" : {e.Type}");
        _sb.AppendLine();
        _sb.AppendLine("{");

        foreach (EnumBinding.EnumValue value in e.Values)
        {
            _sb.Append(' ', 4);
            string valueName = value.Name;
            // while ideally the name prettifier will have been configured to prefix numbers with a usable name,
            // this acts as a "last line of defence" and inserts an underscore to prevent invalid code from being generated.
            if (char.IsNumber(valueName[0]))
                valueName = valueName.Insert(0, "_");
            _sb.Append(valueName);
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
        _sb.Append($"public unsafe struct {s.Name}");
        if (s.IsHandleType && options.HandleTypesUseIHandleInterface)
            _sb.Append(" : piko.Core.IHandle");
        _sb.AppendLine();
        _sb.AppendLine("{");

        if (s.IsHandleType)
        {
            _sb.AppendLine($$"""
                                 private readonly nint _handle;

                                 public nint Handle => _handle;
                                 public bool IsNull => _handle == 0;

                                 public {{s.Name}}(nint handle)
                                 {
                                     _handle = handle;
                                 }
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

    private void WriteConstant(ConstantBinding c, bool force)
    {
        if (!force)
        {
            if (c.SkipGenerationInMainClass)
                return;

            if (c.ClassName != null)
            {
                if (!_constantTypes.TryGetValue(c.ClassName, out List<ConstantBinding> constants))
                {
                    constants = [];
                    _constantTypes.Add(c.ClassName, constants);
                }

                constants.Add(c);
                return;
            }
        }

        _sb.AppendLine($"    public const {c.Type} {c.Name} = {c.Value};");
    }

    private void WriteFunction(FunctionBinding f)
    {
        string returnType = f.ReturnType ?? "void";

        if (options.UseLibraryImport)
        {
            _sb.Append($"    [LibraryImport(LibraryName, EntryPoint = \"{f.PInvokeName}\"");
            if (options.AllStringsAreUTF8)
                _sb.Append(", StringMarshalling = StringMarshalling.Utf8");
            _sb.AppendLine(")]");

            if (options.UseLibraryImport && GetMarshalInfoIfNeeded(returnType, true) is string returnMarshal)
                _sb.AppendLine($"    [return: {returnMarshal}]");

            _sb.Append($"    public static partial {returnType} {f.Name}(");
        }
        else
        {
            _sb.AppendLine($"    [DllImport(LibraryName, EntryPoint = \"{f.PInvokeName}\")]");
            _sb.Append($"    public static extern {returnType} {f.Name}(");
        }

        WriteFunctionParameters(f);
        _sb.AppendLine(");");
        _sb.AppendLine();
    }

    private void WriteDelegate(FunctionBinding d)
    {
        string returnType = d.ReturnType ?? "void";
        _sb.Append($"    public delegate {returnType} {d.Name}(");
        WriteFunctionParameters(d);
        _sb.AppendLine(");");
        _sb.AppendLine();
    }

    private void WriteFunctionParameters(FunctionBinding f)
    {
        int i = 0;
        foreach (FunctionBinding.Parameter parameter in f.Parameters)
        {
            if (options.UseLibraryImport && GetMarshalInfoIfNeeded(parameter.Type, false) is string parameterMarshal)
                _sb.Append($"[{parameterMarshal}] ");

            switch (parameter.FlowDirection)
            {
                // no flow direction to apply
                case PointerFlowDirection.None:
                    break;
                case PointerFlowDirection.In:
                    _sb.Append("in ");
                    break;
                case PointerFlowDirection.Out:
                    _sb.Append("out ");
                    break;
                case PointerFlowDirection.InAndOut:
                    _sb.Append("ref ");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _sb.Append(parameter.Type);
            _sb.Append(' ');
            _sb.Append(parameter.Name);
            if (++i < f.Parameters.Count)
                _sb.Append(", ");
        }
    }

    private string WriteExtraStuff(string str)
    {
        if (options.AllTypesAreSubTypes)
        {
            _sb.Clear();
            _sb.AppendLine($"public static unsafe partial class {methodClassName}");
            _sb.AppendLine("{");
            _sb.Append(' ', 4);
            _sb.AppendLine(str.Replace("\n", "\n    "));
            _sb.AppendLine("}");
        }

        return _sb.ToString();
    }

    private string? GetMarshalInfoIfNeeded(string type, bool isReturnValue)
    {
        if (isReturnValue && (options.CustomReturnValueTypeMarshallers?.TryGetValue(type, out string customMarshaller) ?? false))
            return $"MarshalUsing(typeof({customMarshaller}))";

        return type switch
        {
            "bool" => "MarshalAs(UnmanagedType.I1)",
            "string" when !options.AllStringsAreUTF8 => "MarshalAs(UnmanagedType.LPStr)",
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
        /// If true, LibraryImport attributes will be generated. Otherwise, DllImport will be used.
        /// </summary>
        public bool UseLibraryImport;

        /// <summary>
        /// If true, all types such as enums and structs, will be a subtype of the method class.
        /// For example, if the method class is "SDL", then this will generate types "SDL.Window" etc.
        /// instead of "Window".
        /// </summary>
        public bool AllTypesAreSubTypes;

        /// <summary>
        /// If true, all handle types will use the IHandle interface.
        /// </summary>
        public bool HandleTypesUseIHandleInterface;

        /// <summary>
        /// Generate StringMarshalling.Utf8 information for all methods that use strings.
        /// </summary>
        public bool AllStringsAreUTF8;

        /// <summary>
        /// Define custom type marshallers for return values, to be used in place of the default ones.
        /// </summary>
        public Dictionary<string, string>? CustomReturnValueTypeMarshallers;
    }
}
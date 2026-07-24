using System.Text;
using piko.Generator.Bindings;

namespace piko.Generator;

public class Generator(BindingsSet bindings)
{
    private readonly StringBuilder _sb = new();

    public Output[] Generate()
    {
        List<Output> outputs = [];

        foreach (EnumBinding e in bindings.Enums)
            outputs.Add(new Output(e.Name, WriteEnum(e)));

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
}
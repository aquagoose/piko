using System.Xml;
using piko.Generator.Bindings;

namespace piko.Generator.Analyzers;

public sealed class ClangSharpAnalyzer(string rspName) : Analyzer
{
    public override BindingsSet Analyze()
    {
        BindingsSet bindings = new BindingsSet();

        XmlDocument xml = new XmlDocument();
        xml.Load($"{rspName}.xml");

        XmlNode? baseNode = xml["bindings"]?["namespace"];
        if (baseNode is null)
            throw new InvalidOperationException("File is not a valid ClangSharp XML file.");

        foreach (XmlNode node in baseNode)
        {
            switch (node.Name)
            {
                case "enumeration":
                    ProcessEnum(node, ref bindings);
                    break;
                case "class":
                    ProcessFunctionSet(node, ref bindings);
                    break;
            }
        }

        return bindings;
    }

    private void ProcessEnum(XmlNode node, ref BindingsSet bindings)
    {
        EnumBinding binding = new EnumBinding
        {
            Name = node.Attributes?["name"]?.Value ?? throw new Exception("Enum name missing."),
            Type = node["type"]?.InnerText
        };

        foreach (XmlNode enumerator in node.SelectNodes("enumerator"))
        {
            string name = enumerator.Attributes?["name"]?.Value ?? throw new Exception("Enumerator name missing.");
            string? value = enumerator["value"]?["code"]?.InnerText;

            binding.Values.Add(new EnumBinding.EnumValue(name, value));
        }

        bindings.Enums.Add(binding);
    }

    private void ProcessFunctionSet(XmlNode node, ref BindingsSet bindings)
    {
        foreach (XmlNode func in node.SelectNodes("function"))
        {
            string functionName = func.Attributes?["name"]?.Value ?? throw new Exception("Function name missing.");
            string? returnType = func["type"]?.InnerText;
            int returnTypePointerLevel = 0;
            if (returnType != null && returnType.EndsWith('*'))
            {
                returnTypePointerLevel = returnType.Count('*');
                returnType = returnType.Substring(0, returnType.Length - returnTypePointerLevel);
            }

            FunctionBinding binding = new FunctionBinding(functionName, functionName, returnType, returnTypePointerLevel);

            XmlNodeList? parameters = func.SelectNodes("param");
            if (parameters != null)
            {
                foreach (XmlNode parameter in parameters)
                {
                    string name = parameter.Attributes?["name"]?.InnerText ?? throw new Exception("Parameter name missing.");
                    string type = parameter["type"]?.InnerText ?? throw new Exception("Parameter type missing.");

                    int pointerLevel = 0;
                    if (type.EndsWith('*'))
                    {
                        // count the pointer level then strip it from the typename
                        pointerLevel = type.Count('*');
                        type = type.Substring(0, type.Length - pointerLevel);
                    }

                    binding.Parameters.Add(new FunctionBinding.Parameter(name, type, pointerLevel));
                }
            }

            bindings.Functions.Add(binding);
        }
    }
}
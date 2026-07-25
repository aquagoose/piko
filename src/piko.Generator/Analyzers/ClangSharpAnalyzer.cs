using System.Runtime.InteropServices;
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
                case "struct":
                    ProcessStruct(node, ref bindings);
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

    private void ProcessStruct(XmlNode node, ref BindingsSet bindings)
    {
        string name = node.Attributes?["name"]?.Value ?? throw new Exception("Struct name missing");

        LayoutKind layout = LayoutKind.Sequential;
        string? structLayout = node.Attributes["layout"]?.Value;
        if (structLayout != null && structLayout.Equals("explicit", StringComparison.InvariantCultureIgnoreCase))
            layout = LayoutKind.Explicit;

        StructBinding binding = new StructBinding(name, layout, false);

        XmlNodeList? fields = node.SelectNodes("field");
        if (fields != null)
        {
            foreach (XmlNode field in fields)
            {
                string fieldName = field.Attributes?["name"]?.Value ?? throw new Exception("Field name missing.");
                string fieldType = field["type"]?.InnerText ?? throw new Exception("Field type missing.");
                string? nativeType = field["type"]?.Attributes?["native"]?.Value;

                int pointerLevel = 0;
                if (fieldType.EndsWith('*'))
                {
                    pointerLevel = fieldType.Count('*');
                    fieldType = fieldType.Substring(0, fieldType.Length - pointerLevel);
                }

                string? fieldOffset = field.Attributes?["offset"]?.InnerText;
                int offset = 0;
                if (fieldOffset != null)
                    offset = int.Parse(fieldOffset);

                binding.Fields.Add(new StructBinding.Field(fieldName, fieldType, nativeType, pointerLevel, offset));
            }
        }

        bindings.Structs.Add(binding);
    }

    private void ProcessFunctionSet(XmlNode node, ref BindingsSet bindings)
    {
        foreach (XmlNode func in node.SelectNodes("function"))
        {
            string functionName = func.Attributes?["name"]?.Value ?? throw new Exception("Function name missing.");
            string? returnType = func["type"]?.InnerText;
            string? returnTypeNativeType = func["type"]?.Attributes["native"]?.Value;

            int returnTypePointerLevel = 0;
            if (returnType != null && returnType.EndsWith('*'))
            {
                returnTypePointerLevel = returnType.Count('*');
                returnType = returnType.Substring(0, returnType.Length - returnTypePointerLevel);
            }

            FunctionBinding binding = new FunctionBinding(functionName, functionName, returnType, returnTypeNativeType, returnTypePointerLevel);

            XmlNodeList? parameters = func.SelectNodes("param");
            if (parameters != null)
            {
                foreach (XmlNode parameter in parameters)
                {
                    string name = parameter.Attributes?["name"]?.InnerText ?? throw new Exception("Parameter name missing.");
                    string type = parameter["type"]?.InnerText ?? throw new Exception("Parameter type missing.");
                    string? nativeType = parameter["type"]?.Attributes?["native"]?.Value;

                    int pointerLevel = 0;
                    if (type.EndsWith('*'))
                    {
                        // count the pointer level then strip it from the typename
                        pointerLevel = type.Count('*');
                        type = type.Substring(0, type.Length - pointerLevel);
                    }

                    binding.Parameters.Add(new FunctionBinding.Parameter(name, type, nativeType, pointerLevel));
                }
            }

            bindings.Functions.Add(binding);
        }
    }
}
using piko.Generator.Bindings;

namespace piko.Generator;

public class NamePrettifier(NamePrettifier.Options options)
{
    /// <summary>
    /// Contains a map of already transformed types.
    /// </summary>
    private readonly Dictionary<string, string> _transformMap = [];

    public void Prettify(ref BindingsSet bindings)
    {
        // do enums first, then structs, then finally functions.
        // this ensures that everything is in the transform map and there does not need to be multiple passes.

        foreach (EnumBinding e in bindings.Enums)
        {
            e.Name = TransformIdentifier(e.Name);

            foreach (EnumBinding.EnumValue value in e.Values)
            {
                value.Name = TransformEnumerator(value.Name, e.Name);
                // some enum values may reference other enum values. therefore, we want to transform those too.
                if (value.Value != null)
                    value.Value = TransformEnumerator(value.Value, e.Name);
            }
        }

        foreach (FunctionBinding f in bindings.Functions)
        {
            f.Name = TransformIdentifier(f.Name);

            foreach (FunctionBinding.Parameter parameter in f.Parameters)
            {
                parameter.Name = TransformParameter(parameter.Name);

                if (_transformMap.TryGetValue(parameter.Type, out string transformed))
                    parameter.Type = transformed;
            }
        }
    }

    private string TransformValue(string name, bool keepCasing, bool startUpperCase)
    {
        string newName = "";

        bool shouldBeUpperCase = startUpperCase;
        foreach (char c in StripPrefix(name))
        {
            switch (c)
            {
                case '_':
                    shouldBeUpperCase = true;
                    break;
                default:
                {
                    if (shouldBeUpperCase || (keepCasing && char.IsUpper(c)))
                        newName += char.ToUpper(c);
                    else
                        newName += char.ToLower(c);

                    shouldBeUpperCase = false;
                    break;
                }
            }
        }

        return newName;
    }

    // Transform identifiers, such as enum/struct names, and function names.
    private string TransformIdentifier(string name)
    {
        if (_transformMap.TryGetValue(name, out string transformed))
            return transformed;

        string newName = TransformValue(name, true, true);

        _transformMap.Add(name, newName);
        return newName;
    }

    private string TransformEnumerator(string name, string nameToStrip)
    {
        if (_transformMap.TryGetValue(name, out string transformed))
            return transformed;

        string newName = TransformValue(name, false, true);
        if (newName.StartsWith(nameToStrip, StringComparison.InvariantCultureIgnoreCase))
            newName = newName.Substring(nameToStrip.Length);

        _transformMap.Add(name, newName);
        return newName;
    }

    private string TransformParameter(string name)
    {
        if (_transformMap.TryGetValue(name, out string transformed))
            return transformed;

        string newName = TransformValue(name, false, false);

        _transformMap.Add(name, newName);
        return newName;
    }

    private string StripPrefix(string name)
    {
        if (options.PrefixToStrip != null && name.StartsWith(options.PrefixToStrip, StringComparison.InvariantCultureIgnoreCase))
            name = name.Substring(options.PrefixToStrip.Length);

        return name;
    }

    public struct Options
    {
        /// <summary>
        /// The prefix to strip from names, for example SDL_
        /// </summary>
        public string? PrefixToStrip;
    }
}
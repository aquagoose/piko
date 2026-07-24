using piko.Generator.Bindings;

namespace piko.Generator;

public class NamePrettifier(NamePrettifier.Options options)
{
    public void Prettify(ref BindingsSet bindings)
    {
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
    }

    // Transform identifiers, such as enum/struct names, and function names.
    private string TransformIdentifier(string name, bool keepCasing = true)
    {
        name = StripPrefix(name);
        string newName = "";

        bool shouldBeUpperCase = true;
        foreach (char c in name)
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

    private string TransformEnumerator(string name, string nameToStrip)
    {
        name = TransformIdentifier(name, false);
        if (name.StartsWith(nameToStrip, StringComparison.InvariantCultureIgnoreCase))
            name = name.Substring(nameToStrip.Length);
        return name;
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
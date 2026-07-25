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
            string originalName = e.Name;
            e.Name = TransformIdentifier(e.Name);

            foreach (EnumBinding.EnumValue value in e.Values)
            {
                value.Name = TransformEnumerator(value.Name, e.Name, originalName);
                // some enum values may reference other enum values. therefore, we want to transform those too.
                if (value.Value != null)
                    value.Value = TransformEnumerator(value.Value, e.Name, originalName);
            }
        }

        // for structs we must do 2 passes.
        // first pass maps all the struct names into the transform map.
        // the reason we need to do this is that struct fields may contain other struct types, that may not be
        // present in the map.
        // performing an initial map pass fixes this issue.
        foreach (StructBinding s in bindings.Structs)
        {
            /*string newName = TransformIdentifier(s.Name);
            _transformMap.Add(s.Name, newName);*/
            // TransformIdentifier adds it to the map on its own, so no need to add it manually.
            TransformIdentifier(s.Name); // todo i don't like this. this feels. cursed.
        }

        // second pass actually does the transforming
        foreach (StructBinding s in bindings.Structs)
        {
            s.Name = _transformMap[s.Name];

            foreach (StructBinding.Field field in s.Fields)
            {
                field.Name = TransformIdentifier(field.Name);
                if (_transformMap.TryGetValue(field.Type, out string transformed))
                    field.Type = transformed;
            }
        }

        foreach (FunctionBinding f in bindings.Functions)
        {
            f.Name = TransformIdentifier(f.Name);
            if (_transformMap.TryGetValue(f.ReturnType, out string newReturnType))
                f.ReturnType = newReturnType;

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

    private string TransformEnumerator(string name, string nameToStrip, string originalEnumName)
    {
        if (_transformMap.TryGetValue(name, out string transformed))
            return transformed;

        string newName = StripPrefix(name).Trim('_');

        // strip the old prefix if valid
        string prefixToStrip = options.EnumPrefixStrip.GetValueOrDefault(originalEnumName, "");
        if (!string.IsNullOrWhiteSpace(prefixToStrip) && newName.StartsWith(prefixToStrip, StringComparison.InvariantCultureIgnoreCase))
            newName = newName.Substring(prefixToStrip.Length);

        // transform the enum name
        newName = TransformValue(newName, false, true);
        if (newName.StartsWith(nameToStrip, StringComparison.InvariantCultureIgnoreCase))
            newName = newName.Substring(nameToStrip.Length);

        // then insert the new prefix, if needed
        newName = newName.Insert(0, options.EnumPrefixRemapping.GetValueOrDefault(originalEnumName, ""));

        _transformMap.Add(name, newName);
        return newName;
    }

    private string TransformParameter(string name)
    {
        return TransformValue(name, false, false);
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

        /// <summary>
        /// Prefix any enum value, whose type matches the key, with the value.
        /// For example, ["SDL_GPUSampleCount"] = "Count" will prefix ALL enum values in that enum with "Count"
        /// </summary>
        public Dictionary<string, string> EnumPrefixRemapping;

        /// <summary>
        /// Strip a prefix from an enum value, whose type matches the key.
        /// For example, ["SDL_AssertType"] = "ASSERTION" will strip "ASSERTION_" from all enum values in that type.
        /// This is NOT case-sensitive.
        /// </summary>
        public Dictionary<string, string> EnumPrefixStrip;
    }
}
using piko.Generator.Bindings;

namespace piko.Generator.Analyzers;

/// <summary>
/// An analyzer is something that analyzes a set of functions and creates a <see cref="Generator"/>.
/// </summary>
public abstract class Analyzer
{
    public abstract BindingsSet Analyze();
}
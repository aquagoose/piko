using piko.Generator;
using piko.Generator.Analyzers;
using piko.Generator.Bindings;

ClangSharpAnalyzer sdl3Anaylyzer = new ClangSharpAnalyzer("SDL3", new ClangSharpAnalyzer.Options
{
    LibraryDllName = "SDL3"
});
BindingsSet sdl3Bindings = sdl3Anaylyzer.Analyze();
NamePrettifier prettifier = new NamePrettifier(new NamePrettifier.Options
{
    PrefixToStrip = "SDL_"
});
prettifier.Prettify(ref sdl3Bindings);

Console.WriteLine(sdl3Bindings);
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

Generator generator = new Generator(sdl3Bindings);
Generator.Output[] outputs = generator.Generate();

foreach (Generator.Output output in outputs)
{
    Console.WriteLine($"{output.TypeName}.cs");
    Console.WriteLine("=====================================================================");
    Console.WriteLine(output.Code);
    Console.WriteLine();
}
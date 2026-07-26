using System.Text;
using piko.Generator;
using piko.Generator.Analyzers;
using piko.Generator.Bindings;

string pikoBase = args[0];

ClangSharpAnalyzer sdl3Anaylyzer = new ClangSharpAnalyzer("SDL3");
BindingsSet sdl3Bindings = sdl3Anaylyzer.Analyze();
NamePrettifier prettifier = new NamePrettifier(new NamePrettifier.Options
{
    PrefixToStrip = "SDL_",
    EnumPrefixRemapping = new Dictionary<string, string>
    {
        { "SDL_GPUIndexElementSize", "Size" },
        { "SDL_GPUTextureType", "Type" },
        { "SDL_GPUSampleCount", "Count" },
        { "SDL_BitmapOrder", "Order" },
        { "SDL_PackedLayout", "Layout" },
        { "SDL_TimeFormat", "Format" }
    },
    EnumPrefixStrip = new Dictionary<string, string>
    {
        { "SDL_AssertState", "ASSERTION" },
        { "SDL_AsyncIOTaskType", "ASYNCIO_TASK" },
        { "SDL_AsyncIOResult", "ASYNCIO" },
        { "SDL_AudioFormat", "AUDIO" },
        { "SDL_FileDialogType", "FILEDIALOG" },
        { "SDL_EventType", "EVENT" },
        { "SDL_EnumerationResult", "ENUM" },
        { "SDL_GamepadBindingType", "GAMEPAD_BINDTYPE" },
        { "SDL_JoystickConnectionState", "JOYSTICK_CONNECTION" },
        { "SDL_Capitalization", "CAPITALIZE" }, // todo maybe this should be kept as-is
        { "SDL_MessageBoxColorType", "MESSAGEBOX_COLOR" },
        { "SDL_MouseWheelDirection", "MOUSEWHEEL" },
        { "SDL_ProcessIO", "PROCESS_STDIO" },
        { "SDL_TextureAddressMode", "TEXTURE_ADDRESS" },
        { "SDL_RendererLogicalPresentation", "LOGICAL_PRESENTATION" },
        { "SDL_SensorType", "SENSOR" },
        { "SDL_FlipMode", "FLIP" }, // todo maybe this also should be kept as-is?
        { "SDL_ThreadState", "THREAD" },
        { "SDL_TouchDeviceType", "TOUCH_DEVICE" },
        { "SDL_DisplayOrientation", "ORIENTATION" },
        { "SDL_FlashOperation", "FLASH" },
        { "SDL_GLAttr", "GL" },
        { "SDL_HitTestResult", "HITTEST" }
    },
    ConstantPrefixStrip = new List<string>
    {
        "SDL_INIT",
        "SDL_WINDOW_",
        "SDL_GPU_SHADERFORMAT",
        "SDL_GPU_BUFFERUSAGE",
        "SDL_GPU_TEXTUREUSAGE",
        "SDL_PROP",
        "SDL_HINT"
    },
    NameRemapping = new Dictionary<string, string>
    {
        { "SDL_InitFlags", "InitFlags" },
        { "SDL_WindowFlags", "WindowFlags" },
        { "SDL_GPUShaderFormat", "GPUShaderFormat" },
        { "SDL_GPUTextureUsage", "GPUTextureUsage" },
        { "SDL_GPUBufferUsage", "GPUBufferUsage" },
    }
});
prettifier.Prettify(ref sdl3Bindings);

TypeTransformer transformer = new TypeTransformer(new TypeTransformer.Options
{
    EmptyStructsAreHandleTypes = true,
    AssociateConstantPrefixWithType = new Dictionary<string, TypeTransformer.ConstantType>
    {
        { "SDL_INIT", new TypeTransformer.ConstantType("InitFlags", true) },
        { "SDL_WINDOW_", new TypeTransformer.ConstantType("WindowFlags", true) },
        { "SDL_GPU_SHADERFORMAT", new TypeTransformer.ConstantType("GPUShaderFormat", true) },
        { "SDL_GPU_BUFFERUSAGE", new TypeTransformer.ConstantType("GPUBufferUsage", true) },
        { "SDL_GPU_TEXTUREUSAGE", new TypeTransformer.ConstantType("GPUTextureUsage", true) },
        { "SDL_PROP", new TypeTransformer.ConstantType("Prop", false) },
        { "SDL_HINT", new TypeTransformer.ConstantType("Hint", false) }
    }
});
transformer.Transform(ref sdl3Bindings);

Generator generator = new Generator(sdl3Bindings, "SDL", new Generator.Options()
{
    LibraryDllName = "SDL3",
    AllTypesAreSubTypes = true
});
Generator.Output[] outputs = generator.Generate();

StringBuilder sb = new StringBuilder();

string sdl3Output = Path.Combine(pikoBase, "src", "piko.SDL3");
foreach (Generator.Output output in outputs)
{
    /*Console.WriteLine($"{output.TypeName}.cs");
    Console.WriteLine("=====================================================================");
    Console.WriteLine(output.Code);
    Console.WriteLine();*/

    sb.Clear();
    sb.AppendLine("using System.Runtime.InteropServices;");
    sb.AppendLine("namespace piko.SDL3;");
    sb.Append(output.Code);

    string filePath = Path.Combine(sdl3Output, $"{output.TypeName}.cs");
    File.WriteAllText(filePath, sb.ToString());
}
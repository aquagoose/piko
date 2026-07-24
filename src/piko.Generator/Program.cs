using piko.Generator;
using piko.Generator.Analyzers;
using piko.Generator.Bindings;

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
    }
});
prettifier.Prettify(ref sdl3Bindings);

Generator generator = new Generator(sdl3Bindings, "SDL", new Generator.Options()
{
    AllTypesAreSubTypes = true
});
Generator.Output[] outputs = generator.Generate();

foreach (Generator.Output output in outputs)
{
    Console.WriteLine($"{output.TypeName}.cs");
    Console.WriteLine("=====================================================================");
    Console.WriteLine(output.Code);
    Console.WriteLine();
}
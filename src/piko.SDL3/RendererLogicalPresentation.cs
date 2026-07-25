using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum RendererLogicalPresentation : uint
    {
        Disabled,
        Stretch,
        Letterbox,
        Overscan,
        IntegerScale,
    }
}

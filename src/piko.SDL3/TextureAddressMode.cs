using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum TextureAddressMode : int
    {
        Invalid = -1,
        Auto,
        Clamp,
        Wrap,
    }
}

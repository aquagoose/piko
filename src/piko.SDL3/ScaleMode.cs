using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ScaleMode : int
    {
        Invalid = -1,
        Nearest,
        Linear,
        Pixelart,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ArrayOrder : uint
    {
        None,
        Rgb,
        Rgba,
        Argb,
        Bgr,
        Bgra,
        Abgr,
    }
}

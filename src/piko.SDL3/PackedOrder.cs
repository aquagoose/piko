using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum PackedOrder : uint
    {
        None,
        Xrgb,
        Rgbx,
        Argb,
        Rgba,
        Xbgr,
        Bgrx,
        Abgr,
        Bgra,
    }
}

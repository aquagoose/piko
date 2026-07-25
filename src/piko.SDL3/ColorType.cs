using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ColorType : uint
    {
        Unknown = 0,
        Rgb = 1,
        Ycbcr = 2,
    }
}

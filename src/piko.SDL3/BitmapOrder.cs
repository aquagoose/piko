using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum BitmapOrder : uint
    {
        OrderNone,
        Order4321,
        Order1234,
    }
}

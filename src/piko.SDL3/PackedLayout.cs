using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum PackedLayout : uint
    {
        LayoutNone,
        Layout332,
        Layout4444,
        Layout1555,
        Layout5551,
        Layout565,
        Layout8888,
        Layout2101010,
        Layout1010102,
    }
}

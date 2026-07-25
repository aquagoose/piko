using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum HitTestResult : uint
    {
        Normal,
        Draggable,
        ResizeTopleft,
        ResizeTop,
        ResizeTopright,
        ResizeRight,
        ResizeBottomright,
        ResizeBottom,
        ResizeBottomleft,
        ResizeLeft,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [Flags]
    public enum WindowFlags : nuint
    {
        Fullscreen = 0x0000000000000001U,
        Opengl = 0x0000000000000002U,
        Occluded = 0x0000000000000004U,
        Hidden = 0x0000000000000008U,
        Borderless = 0x0000000000000010U,
        Resizable = 0x0000000000000020U,
        Minimized = 0x0000000000000040U,
        Maximized = 0x0000000000000080U,
        MouseGrabbed = 0x0000000000000100U,
        InputFocus = 0x0000000000000200U,
        MouseFocus = 0x0000000000000400U,
        External = 0x0000000000000800U,
        Modal = 0x0000000000001000U,
        HighPixelDensity = 0x0000000000002000U,
        MouseCapture = 0x0000000000004000U,
        MouseRelativeMode = 0x0000000000008000U,
        AlwaysOnTop = 0x0000000000010000U,
        Utility = 0x0000000000020000U,
        Tooltip = 0x0000000000040000U,
        PopupMenu = 0x0000000000080000U,
        KeyboardGrabbed = 0x0000000000100000U,
        FillDocument = 0x0000000000200000U,
        Vulkan = 0x0000000010000000U,
        Metal = 0x0000000020000000U,
        Transparent = 0x0000000040000000U,
        NotFocusable = 0x0000000080000000U,
        SurfaceVsyncDisabled = 0,
        SurfaceVsyncAdaptive = (-1),
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum InitFlags : uint
    {
        Audio = 0x00000010U,
        Video = 0x00000020U,
        Joystick = 0x00000200U,
        Haptic = 0x00001000U,
        Gamepad = 0x00002000U,
        Events = 0x00004000U,
        Sensor = 0x00008000U,
        Camera = 0x00010000U,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum JoystickConnectionState : int
    {
        Invalid = -1,
        Unknown,
        Wired,
        Wireless,
    }
}

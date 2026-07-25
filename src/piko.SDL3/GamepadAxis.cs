using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GamepadAxis : int
    {
        Invalid = -1,
        Leftx,
        Lefty,
        Rightx,
        Righty,
        LeftTrigger,
        RightTrigger,
        Count,
    }
}

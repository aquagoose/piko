using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GamepadBindingType : uint
    {
        None = 0,
        Button,
        Axis,
        Hat,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GamepadButtonLabel : uint
    {
        Unknown,
        A,
        B,
        X,
        Y,
        Cross,
        Circle,
        Square,
        Triangle,
    }
}

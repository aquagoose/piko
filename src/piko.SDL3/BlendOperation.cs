using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum BlendOperation : uint
    {
        Add = 0x1,
        Subtract = 0x2,
        RevSubtract = 0x3,
        Minimum = 0x4,
        Maximum = 0x5,
    }
}

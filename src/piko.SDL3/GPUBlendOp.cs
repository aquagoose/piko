using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GPUBlendOp : uint
    {
        Invalid,
        Add,
        Subtract,
        ReverseSubtract,
        Min,
        Max,
    }
}

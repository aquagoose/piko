using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GPUTextureUsage : uint
    {
        Sampler = (1U << 0),
        ColorTarget = (1U << 1),
        DepthStencilTarget = (1U << 2),
        GraphicsStorageRead = (1U << 3),
        ComputeStorageRead = (1U << 4),
        ComputeStorageWrite = (1U << 5),
        ComputeStorageSimultaneousReadWrite = (1U << 6),
    }
}

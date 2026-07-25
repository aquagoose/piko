using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GPUBufferUsage : uint
    {
        Vertex = (1U << 0),
        Index = (1U << 1),
        Indirect = (1U << 2),
        GraphicsStorageRead = (1U << 3),
        ComputeStorageRead = (1U << 4),
        ComputeStorageWrite = (1U << 5),
    }
}

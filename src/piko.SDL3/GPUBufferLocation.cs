using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUBufferLocation
    {
        public GPUBuffer Buffer;
        public uint Offset;
    
        public GPUBufferLocation(GPUBuffer buffer, uint offset)
        {
            this.Buffer = buffer;
            this.Offset = offset;
        }
    }
}

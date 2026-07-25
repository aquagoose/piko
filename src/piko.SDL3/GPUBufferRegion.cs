using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUBufferRegion
    {
        public GPUBuffer Buffer;
        public uint Offset;
        public uint Size;
    
        public GPUBufferRegion(GPUBuffer buffer, uint offset, uint size)
        {
            this.Buffer = buffer;
            this.Offset = offset;
            this.Size = size;
        }
    }
}

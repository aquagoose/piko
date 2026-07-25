using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUVertexAttribute
    {
        public uint Location;
        public uint BufferSlot;
        public GPUVertexElementFormat Format;
        public uint Offset;
    
        public GPUVertexAttribute(uint location, uint bufferSlot, GPUVertexElementFormat format, uint offset)
        {
            this.Location = location;
            this.BufferSlot = bufferSlot;
            this.Format = format;
            this.Offset = offset;
        }
    }
}

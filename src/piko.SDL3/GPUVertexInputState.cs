using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUVertexInputState
    {
        public GPUVertexBufferDescription* VertexBufferDescriptions;
        public uint NumVertexBuffers;
        public GPUVertexAttribute* VertexAttributes;
        public uint NumVertexAttributes;
    
        public GPUVertexInputState(GPUVertexBufferDescription* vertexBufferDescriptions, uint numVertexBuffers, GPUVertexAttribute* vertexAttributes, uint numVertexAttributes)
        {
            this.VertexBufferDescriptions = vertexBufferDescriptions;
            this.NumVertexBuffers = numVertexBuffers;
            this.VertexAttributes = vertexAttributes;
            this.NumVertexAttributes = numVertexAttributes;
        }
    }
}

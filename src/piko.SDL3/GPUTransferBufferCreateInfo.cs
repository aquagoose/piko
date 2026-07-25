using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUTransferBufferCreateInfo
    {
        public GPUTransferBufferUsage Usage;
        public uint Size;
        public uint Props;
    
        public GPUTransferBufferCreateInfo(GPUTransferBufferUsage usage, uint size, uint props)
        {
            this.Usage = usage;
            this.Size = size;
            this.Props = props;
        }
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUTransferBufferLocation
    {
        public GPUTransferBuffer TransferBuffer;
        public uint Offset;
    
        public GPUTransferBufferLocation(GPUTransferBuffer transferBuffer, uint offset)
        {
            this.TransferBuffer = transferBuffer;
            this.Offset = offset;
        }
    }
}

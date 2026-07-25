using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUBufferCreateInfo
    {
        public uint Usage;
        public uint Size;
        public uint Props;
    
        public GPUBufferCreateInfo(uint usage, uint size, uint props)
        {
            this.Usage = usage;
            this.Size = size;
            this.Props = props;
        }
    }
}

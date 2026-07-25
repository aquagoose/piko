using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AtomicU32
    {
        public uint Value;
    
        public AtomicU32(uint value)
        {
            this.Value = value;
        }
    }
}

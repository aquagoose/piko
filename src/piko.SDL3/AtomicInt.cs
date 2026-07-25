using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AtomicInt
    {
        public int Value;
    
        public AtomicInt(int value)
        {
            this.Value = value;
        }
    }
}

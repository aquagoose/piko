using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AlignmentTest
    {
        public byte A;
        public void* B;
    
        public AlignmentTest(byte a, void* b)
        {
            this.A = a;
            this.B = b;
        }
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticDirection
    {
        public byte Type;
        public int Dir;
    
        public HapticDirection(byte type, int dir)
        {
            this.Type = type;
            this.Dir = dir;
        }
    }
}

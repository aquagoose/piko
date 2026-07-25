using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FPoint
    {
        public float X;
        public float Y;
    
        public FPoint(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

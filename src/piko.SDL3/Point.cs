using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Point
    {
        public int X;
        public int Y;
    
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

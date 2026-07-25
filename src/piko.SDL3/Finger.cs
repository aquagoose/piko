using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Finger
    {
        public nuint Id;
        public float X;
        public float Y;
        public float Pressure;
    
        public Finger(nuint id, float x, float y, float pressure)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
            this.Pressure = pressure;
        }
    }
}

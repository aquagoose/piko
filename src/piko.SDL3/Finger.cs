using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Finger
    {
        public ulong Id;
        public float X;
        public float Y;
        public float Pressure;
    
        public Finger(ulong id, float x, float y, float pressure)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
            this.Pressure = pressure;
        }
    }
}

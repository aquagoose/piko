using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GamepadTouchpadEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint Which;
        public int Touchpad;
        public int Finger;
        public float X;
        public float Y;
        public float Pressure;
    
        public GamepadTouchpadEvent(EventType type, uint reserved, ulong timestamp, uint which, int touchpad, int finger, float x, float y, float pressure)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.Touchpad = touchpad;
            this.Finger = finger;
            this.X = x;
            this.Y = y;
            this.Pressure = pressure;
        }
    }
}

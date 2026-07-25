using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TouchFingerEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public nuint TouchID;
        public nuint FingerID;
        public float X;
        public float Y;
        public float Dx;
        public float Dy;
        public float Pressure;
        public uint WindowID;
    
        public TouchFingerEvent(EventType type, uint reserved, nuint timestamp, nuint touchID, nuint fingerID, float x, float y, float dx, float dy, float pressure, uint windowID)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.TouchID = touchID;
            this.FingerID = fingerID;
            this.X = x;
            this.Y = y;
            this.Dx = dx;
            this.Dy = dy;
            this.Pressure = pressure;
            this.WindowID = windowID;
        }
    }
}

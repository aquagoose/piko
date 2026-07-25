using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PenTouchEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint WindowID;
        public uint Which;
        public uint PenState;
        public float X;
        public float Y;
        public bool Eraser;
        public bool Down;
    
        public PenTouchEvent(EventType type, uint reserved, nuint timestamp, uint windowID, uint which, uint penState, float x, float y, bool eraser, bool down)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Which = which;
            this.PenState = penState;
            this.X = x;
            this.Y = y;
            this.Eraser = eraser;
            this.Down = down;
        }
    }
}

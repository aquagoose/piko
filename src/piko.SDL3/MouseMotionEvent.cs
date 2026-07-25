using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MouseMotionEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint WindowID;
        public uint Which;
        public uint State;
        public float X;
        public float Y;
        public float Xrel;
        public float Yrel;
    
        public MouseMotionEvent(EventType type, uint reserved, nuint timestamp, uint windowID, uint which, uint state, float x, float y, float xrel, float yrel)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Which = which;
            this.State = state;
            this.X = x;
            this.Y = y;
            this.Xrel = xrel;
            this.Yrel = yrel;
        }
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MouseButtonEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint WindowID;
        public uint Which;
        public byte Button;
        public bool Down;
        public byte Clicks;
        public byte Padding;
        public float X;
        public float Y;
    
        public MouseButtonEvent(EventType type, uint reserved, ulong timestamp, uint windowID, uint which, byte button, bool down, byte clicks, byte padding, float x, float y)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Which = which;
            this.Button = button;
            this.Down = down;
            this.Clicks = clicks;
            this.Padding = padding;
            this.X = x;
            this.Y = y;
        }
    }
}

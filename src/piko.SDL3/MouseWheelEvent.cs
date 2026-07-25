using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MouseWheelEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint WindowID;
        public uint Which;
        public float X;
        public float Y;
        public MouseWheelDirection Direction;
        public float MouseX;
        public float MouseY;
        public int IntegerX;
        public int IntegerY;
    
        public MouseWheelEvent(EventType type, uint reserved, nuint timestamp, uint windowID, uint which, float x, float y, MouseWheelDirection direction, float mouseX, float mouseY, int integerX, int integerY)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Which = which;
            this.X = x;
            this.Y = y;
            this.Direction = direction;
            this.MouseX = mouseX;
            this.MouseY = mouseY;
            this.IntegerX = integerX;
            this.IntegerY = integerY;
        }
    }
}

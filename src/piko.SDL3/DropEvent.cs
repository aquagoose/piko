using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DropEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint WindowID;
        public float X;
        public float Y;
        public sbyte* Source;
        public sbyte* Data;
    
        public DropEvent(EventType type, uint reserved, nuint timestamp, uint windowID, float x, float y, sbyte* source, sbyte* data)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.X = x;
            this.Y = y;
            this.Source = source;
            this.Data = data;
        }
    }
}

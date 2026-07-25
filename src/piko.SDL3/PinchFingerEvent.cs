using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PinchFingerEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public float Scale;
        public uint WindowID;
    
        public PinchFingerEvent(EventType type, uint reserved, ulong timestamp, float scale, uint windowID)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Scale = scale;
            this.WindowID = windowID;
        }
    }
}

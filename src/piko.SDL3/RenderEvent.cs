using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RenderEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint WindowID;
    
        public RenderEvent(EventType type, uint reserved, ulong timestamp, uint windowID)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
        }
    }
}

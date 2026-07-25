using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct KeyboardDeviceEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint Which;
    
        public KeyboardDeviceEvent(EventType type, uint reserved, ulong timestamp, uint which)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
        }
    }
}

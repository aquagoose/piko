using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GamepadDeviceEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint Which;
    
        public GamepadDeviceEvent(EventType type, uint reserved, nuint timestamp, uint which)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
        }
    }
}

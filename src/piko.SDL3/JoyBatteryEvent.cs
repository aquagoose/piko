using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JoyBatteryEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint Which;
        public PowerState State;
        public int Percent;
    
        public JoyBatteryEvent(EventType type, uint reserved, nuint timestamp, uint which, PowerState state, int percent)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.State = state;
            this.Percent = percent;
        }
    }
}

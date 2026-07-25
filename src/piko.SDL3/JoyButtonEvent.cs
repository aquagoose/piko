using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JoyButtonEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint Which;
        public byte Button;
        public bool Down;
        public byte Padding1;
        public byte Padding2;
    
        public JoyButtonEvent(EventType type, uint reserved, nuint timestamp, uint which, byte button, bool down, byte padding1, byte padding2)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.Button = button;
            this.Down = down;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
        }
    }
}

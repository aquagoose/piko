using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JoyBallEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint Which;
        public byte Ball;
        public byte Padding1;
        public byte Padding2;
        public byte Padding3;
        public short Xrel;
        public short Yrel;
    
        public JoyBallEvent(EventType type, uint reserved, ulong timestamp, uint which, byte ball, byte padding1, byte padding2, byte padding3, short xrel, short yrel)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.Ball = ball;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
            this.Padding3 = padding3;
            this.Xrel = xrel;
            this.Yrel = yrel;
        }
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JoyAxisEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint Which;
        public byte Axis;
        public byte Padding1;
        public byte Padding2;
        public byte Padding3;
        public short Value;
        public ushort Padding4;
    
        public JoyAxisEvent(EventType type, uint reserved, ulong timestamp, uint which, byte axis, byte padding1, byte padding2, byte padding3, short value, ushort padding4)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.Axis = axis;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
            this.Padding3 = padding3;
            this.Value = value;
            this.Padding4 = padding4;
        }
    }
}

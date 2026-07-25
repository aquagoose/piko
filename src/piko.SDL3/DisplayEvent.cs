using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DisplayEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint DisplayID;
        public int Data1;
        public int Data2;
    
        public DisplayEvent(EventType type, uint reserved, ulong timestamp, uint displayID, int data1, int data2)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.DisplayID = displayID;
            this.Data1 = data1;
            this.Data2 = data2;
        }
    }
}

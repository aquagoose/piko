using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UserEvent
    {
        public uint Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint WindowID;
        public int Code;
        public void* Data1;
        public void* Data2;
    
        public UserEvent(uint type, uint reserved, ulong timestamp, uint windowID, int code, void* data1, void* data2)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Code = code;
            this.Data1 = data1;
            this.Data2 = data2;
        }
    }
}

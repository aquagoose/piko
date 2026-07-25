using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CommonEvent
    {
        public uint Type;
        public uint Reserved;
        public nuint Timestamp;
    
        public CommonEvent(uint type, uint reserved, nuint timestamp)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
        }
    }
}

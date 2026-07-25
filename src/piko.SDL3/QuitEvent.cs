using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct QuitEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
    
        public QuitEvent(EventType type, uint reserved, nuint timestamp)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
        }
    }
}

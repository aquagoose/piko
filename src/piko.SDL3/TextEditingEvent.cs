using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TextEditingEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint WindowID;
        public sbyte* Text;
        public int Start;
        public int Length;
    
        public TextEditingEvent(EventType type, uint reserved, ulong timestamp, uint windowID, sbyte* text, int start, int length)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Text = text;
            this.Start = start;
            this.Length = length;
        }
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ClipboardEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public bool Owner;
        public int NumMimeTypes;
        public sbyte** MimeTypes;
    
        public ClipboardEvent(EventType type, uint reserved, nuint timestamp, bool owner, int numMimeTypes, sbyte** mimeTypes)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Owner = owner;
            this.NumMimeTypes = numMimeTypes;
            this.MimeTypes = mimeTypes;
        }
    }
}

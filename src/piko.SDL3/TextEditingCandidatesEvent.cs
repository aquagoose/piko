using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TextEditingCandidatesEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint WindowID;
        public sbyte** Candidates;
        public int NumCandidates;
        public int SelectedCandidate;
        public bool Horizontal;
        public byte Padding1;
        public byte Padding2;
        public byte Padding3;
    
        public TextEditingCandidatesEvent(EventType type, uint reserved, ulong timestamp, uint windowID, sbyte** candidates, int numCandidates, int selectedCandidate, bool horizontal, byte padding1, byte padding2, byte padding3)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.WindowID = windowID;
            this.Candidates = candidates;
            this.NumCandidates = numCandidates;
            this.SelectedCandidate = selectedCandidate;
            this.Horizontal = horizontal;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
            this.Padding3 = padding3;
        }
    }
}

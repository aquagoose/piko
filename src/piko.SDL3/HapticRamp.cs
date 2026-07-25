using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticRamp
    {
        public ushort Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public short Start;
        public short End;
        public ushort AttackLength;
        public ushort AttackLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    
        public HapticRamp(ushort type, HapticDirection direction, uint length, ushort delay, ushort button, ushort interval, short start, short end, ushort attackLength, ushort attackLevel, ushort fadeLength, ushort fadeLevel)
        {
            this.Type = type;
            this.Direction = direction;
            this.Length = length;
            this.Delay = delay;
            this.Button = button;
            this.Interval = interval;
            this.Start = start;
            this.End = end;
            this.AttackLength = attackLength;
            this.AttackLevel = attackLevel;
            this.FadeLength = fadeLength;
            this.FadeLevel = fadeLevel;
        }
    }
}

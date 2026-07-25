using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticPeriodic
    {
        public ushort Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public ushort Period;
        public short Magnitude;
        public short Offset;
        public ushort Phase;
        public ushort AttackLength;
        public ushort AttackLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    
        public HapticPeriodic(ushort type, HapticDirection direction, uint length, ushort delay, ushort button, ushort interval, ushort period, short magnitude, short offset, ushort phase, ushort attackLength, ushort attackLevel, ushort fadeLength, ushort fadeLevel)
        {
            this.Type = type;
            this.Direction = direction;
            this.Length = length;
            this.Delay = delay;
            this.Button = button;
            this.Interval = interval;
            this.Period = period;
            this.Magnitude = magnitude;
            this.Offset = offset;
            this.Phase = phase;
            this.AttackLength = attackLength;
            this.AttackLevel = attackLevel;
            this.FadeLength = fadeLength;
            this.FadeLevel = fadeLevel;
        }
    }
}

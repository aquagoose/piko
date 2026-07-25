using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticConstant
    {
        public ushort Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public short Level;
        public ushort AttackLength;
        public ushort AttackLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    
        public HapticConstant(ushort type, HapticDirection direction, uint length, ushort delay, ushort button, ushort interval, short level, ushort attackLength, ushort attackLevel, ushort fadeLength, ushort fadeLevel)
        {
            this.Type = type;
            this.Direction = direction;
            this.Length = length;
            this.Delay = delay;
            this.Button = button;
            this.Interval = interval;
            this.Level = level;
            this.AttackLength = attackLength;
            this.AttackLevel = attackLevel;
            this.FadeLength = fadeLength;
            this.FadeLevel = fadeLevel;
        }
    }
}

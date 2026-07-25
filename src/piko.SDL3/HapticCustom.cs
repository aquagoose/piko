using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticCustom
    {
        public ushort Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public byte Channels;
        public ushort Period;
        public ushort Samples;
        public ushort* Data;
        public ushort AttackLength;
        public ushort AttackLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    
        public HapticCustom(ushort type, HapticDirection direction, uint length, ushort delay, ushort button, ushort interval, byte channels, ushort period, ushort samples, ushort* data, ushort attackLength, ushort attackLevel, ushort fadeLength, ushort fadeLevel)
        {
            this.Type = type;
            this.Direction = direction;
            this.Length = length;
            this.Delay = delay;
            this.Button = button;
            this.Interval = interval;
            this.Channels = channels;
            this.Period = period;
            this.Samples = samples;
            this.Data = data;
            this.AttackLength = attackLength;
            this.AttackLevel = attackLevel;
            this.FadeLength = fadeLength;
            this.FadeLevel = fadeLevel;
        }
    }
}

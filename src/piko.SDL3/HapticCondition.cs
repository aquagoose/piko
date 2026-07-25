using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticCondition
    {
        public ushort Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public ushort RightSat;
        public ushort LeftSat;
        public short RightCoeff;
        public short LeftCoeff;
        public ushort Deadband;
        public short Center;
    
        public HapticCondition(ushort type, HapticDirection direction, uint length, ushort delay, ushort button, ushort interval, ushort rightSat, ushort leftSat, short rightCoeff, short leftCoeff, ushort deadband, short center)
        {
            this.Type = type;
            this.Direction = direction;
            this.Length = length;
            this.Delay = delay;
            this.Button = button;
            this.Interval = interval;
            this.RightSat = rightSat;
            this.LeftSat = leftSat;
            this.RightCoeff = rightCoeff;
            this.LeftCoeff = leftCoeff;
            this.Deadband = deadband;
            this.Center = center;
        }
    }
}

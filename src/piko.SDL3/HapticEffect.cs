using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct HapticEffect
    {
        [FieldOffset(0)] public ushort Type;
        [FieldOffset(0)] public HapticConstant Constant;
        [FieldOffset(0)] public HapticPeriodic Periodic;
        [FieldOffset(0)] public HapticCondition Condition;
        [FieldOffset(0)] public HapticRamp Ramp;
        [FieldOffset(0)] public HapticLeftRight Leftright;
        [FieldOffset(0)] public HapticCustom Custom;
    
        public HapticEffect(ushort type, HapticConstant constant, HapticPeriodic periodic, HapticCondition condition, HapticRamp ramp, HapticLeftRight leftright, HapticCustom custom)
        {
            this.Type = type;
            this.Constant = constant;
            this.Periodic = periodic;
            this.Condition = condition;
            this.Ramp = ramp;
            this.Leftright = leftright;
            this.Custom = custom;
        }
    }
}

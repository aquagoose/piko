using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HapticLeftRight
    {
        public ushort Type;
        public uint Length;
        public ushort LargeMagnitude;
        public ushort SmallMagnitude;
    
        public HapticLeftRight(ushort type, uint length, ushort largeMagnitude, ushort smallMagnitude)
        {
            this.Type = type;
            this.Length = length;
            this.LargeMagnitude = largeMagnitude;
            this.SmallMagnitude = smallMagnitude;
        }
    }
}

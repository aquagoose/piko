using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualJoystickTouchpadDesc
    {
        public ushort Nfingers;
        public ushort Padding;
    
        public VirtualJoystickTouchpadDesc(ushort nfingers, ushort padding)
        {
            this.Nfingers = nfingers;
            this.Padding = padding;
        }
    }
}

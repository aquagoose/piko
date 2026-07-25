using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualJoystickSensorDesc
    {
        public SensorType Type;
        public float Rate;
    
        public VirtualJoystickSensorDesc(SensorType type, float rate)
        {
            this.Type = type;
            this.Rate = rate;
        }
    }
}

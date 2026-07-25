using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum SensorType : int
    {
        Invalid = -1,
        Unknown,
        Accel,
        Gyro,
        AccelL,
        GyroL,
        AccelR,
        GyroR,
        Count,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum PenAxis : uint
    {
        Pressure,
        Xtilt,
        Ytilt,
        Distance,
        Rotation,
        Slider,
        TangentialPressure,
        Count,
    }
}

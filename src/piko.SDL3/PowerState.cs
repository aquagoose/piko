using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum PowerState : int
    {
        Error = -1,
        Unknown,
        OnBattery,
        NoBattery,
        Charging,
        Charged,
    }
}

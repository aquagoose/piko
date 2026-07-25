using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum TimeFormat : uint
    {
        Format24hr = 0,
        Format12hr = 1,
    }
}

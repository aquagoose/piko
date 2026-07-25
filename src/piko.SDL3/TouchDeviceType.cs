using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum TouchDeviceType : int
    {
        Invalid = -1,
        Direct,
        IndirectAbsolute,
        IndirectRelative,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GPUSwapchainComposition : uint
    {
        Sdr,
        SdrLinear,
        HdrExtendedLinear,
        Hdr10St2084,
    }
}

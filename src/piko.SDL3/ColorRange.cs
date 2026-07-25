using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ColorRange : uint
    {
        Unknown = 0,
        Limited = 1,
        Full = 2,
    }
}

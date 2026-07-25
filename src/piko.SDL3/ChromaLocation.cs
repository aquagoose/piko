using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ChromaLocation : uint
    {
        None = 0,
        Left = 1,
        Center = 2,
        Topleft = 3,
    }
}

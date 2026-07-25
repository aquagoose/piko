using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GPUCubeMapFace : uint
    {
        Positivex,
        Negativex,
        Positivey,
        Negativey,
        Positivez,
        Negativez,
    }
}

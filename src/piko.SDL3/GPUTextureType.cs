using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GPUTextureType : uint
    {
        Type2d,
        Type2dArray,
        Type3d,
        TypeCube,
        TypeCubeArray,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum CameraPermissionState : int
    {
        Denied = -1,
        Pending,
        Approved,
    }
}

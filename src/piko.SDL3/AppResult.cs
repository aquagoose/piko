using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum AppResult : uint
    {
        AppContinue,
        AppSuccess,
        AppFailure,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ProgressState : int
    {
        Invalid = -1,
        None,
        Indeterminate,
        Normal,
        Paused,
        Error,
    }
}

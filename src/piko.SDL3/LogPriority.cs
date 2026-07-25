using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum LogPriority : uint
    {
        Invalid,
        Trace,
        Verbose,
        Debug,
        Info,
        Warn,
        Error,
        Critical,
        Count,
    }
}

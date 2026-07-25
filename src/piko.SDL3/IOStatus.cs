using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum IOStatus : uint
    {
        Ready,
        Error,
        Eof,
        NotReady,
        Readonly,
        Writeonly,
    }
}

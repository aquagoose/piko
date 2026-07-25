using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum ProcessIO : uint
    {
        Inherited,
        Null,
        App,
        Redirect,
    }
}

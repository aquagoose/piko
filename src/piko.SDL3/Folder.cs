using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum Folder : uint
    {
        Home,
        Desktop,
        Documents,
        Downloads,
        Music,
        Pictures,
        Publicshare,
        Savedgames,
        Screenshots,
        Templates,
        Videos,
        Count,
    }
}

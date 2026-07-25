using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum MessageBoxColorType : uint
    {
        Background,
        Text,
        ButtonBorder,
        ButtonBackground,
        ButtonSelected,
        Count,
    }
}

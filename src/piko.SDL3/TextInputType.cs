using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum TextInputType : uint
    {
        Text,
        TextName,
        TextEmail,
        TextUsername,
        TextPasswordHidden,
        TextPasswordVisible,
        Number,
        NumberPasswordHidden,
        NumberPasswordVisible,
    }
}

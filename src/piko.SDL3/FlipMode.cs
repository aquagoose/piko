using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum FlipMode : uint
    {
        None,
        Horizontal,
        Vertical,
        //todo HorizontalAndVertical = (sdlFlipHorizontal | sdlFlipVertical),
        HorizontalAndVertical = (Horizontal | Vertical),
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CursorFrameInfo
    {
        public Surface* Surface;
        public uint Duration;
    
        public CursorFrameInfo(Surface* surface, uint duration)
        {
            this.Surface = surface;
            this.Duration = duration;
        }
    }
}

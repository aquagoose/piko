using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Texture
    {
        public PixelFormat Format;
        public int W;
        public int H;
        public int Refcount;
    
        public Texture(PixelFormat format, int w, int h, int refcount)
        {
            this.Format = format;
            this.W = w;
            this.H = h;
            this.Refcount = refcount;
        }
    }
}

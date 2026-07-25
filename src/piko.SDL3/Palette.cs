using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Palette
    {
        public int Ncolors;
        public Color* Colors;
        public uint Version;
        public int Refcount;
    
        public Palette(int ncolors, Color* colors, uint version, int refcount)
        {
            this.Ncolors = ncolors;
            this.Colors = colors;
            this.Version = version;
            this.Refcount = refcount;
        }
    }
}

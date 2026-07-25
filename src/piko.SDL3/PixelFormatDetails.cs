using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PixelFormatDetails
    {
        public PixelFormat Format;
        public byte BitsPerPixel;
        public byte BytesPerPixel;
        public byte Padding;
        public uint Rmask;
        public uint Gmask;
        public uint Bmask;
        public uint Amask;
        public byte Rbits;
        public byte Gbits;
        public byte Bbits;
        public byte Abits;
        public byte Rshift;
        public byte Gshift;
        public byte Bshift;
        public byte Ashift;
    
        public PixelFormatDetails(PixelFormat format, byte bitsPerPixel, byte bytesPerPixel, byte padding, uint rmask, uint gmask, uint bmask, uint amask, byte rbits, byte gbits, byte bbits, byte abits, byte rshift, byte gshift, byte bshift, byte ashift)
        {
            this.Format = format;
            this.BitsPerPixel = bitsPerPixel;
            this.BytesPerPixel = bytesPerPixel;
            this.Padding = padding;
            this.Rmask = rmask;
            this.Gmask = gmask;
            this.Bmask = bmask;
            this.Amask = amask;
            this.Rbits = rbits;
            this.Gbits = gbits;
            this.Bbits = bbits;
            this.Abits = abits;
            this.Rshift = rshift;
            this.Gshift = gshift;
            this.Bshift = bshift;
            this.Ashift = ashift;
        }
    }
}

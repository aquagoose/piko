using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DisplayMode
    {
        public uint DisplayID;
        public PixelFormat Format;
        public int W;
        public int H;
        public float PixelDensity;
        public float RefreshRate;
        public int RefreshRateNumerator;
        public int RefreshRateDenominator;
        public DisplayModeData @internal;
    
        public DisplayMode(uint displayID, PixelFormat format, int w, int h, float pixelDensity, float refreshRate, int refreshRateNumerator, int refreshRateDenominator, DisplayModeData @internal)
        {
            this.DisplayID = displayID;
            this.Format = format;
            this.W = w;
            this.H = h;
            this.PixelDensity = pixelDensity;
            this.RefreshRate = refreshRate;
            this.RefreshRateNumerator = refreshRateNumerator;
            this.RefreshRateDenominator = refreshRateDenominator;
            this.@internal = @internal;
        }
    }
}

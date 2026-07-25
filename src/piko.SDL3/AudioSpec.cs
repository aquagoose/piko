using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AudioSpec
    {
        public AudioFormat Format;
        public int Channels;
        public int Freq;
    
        public AudioSpec(AudioFormat format, int channels, int freq)
        {
            this.Format = format;
            this.Channels = channels;
            this.Freq = freq;
        }
    }
}

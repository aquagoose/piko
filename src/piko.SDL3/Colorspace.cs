using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum Colorspace : uint
    {
        Unknown = 0,
        Srgb = 0x120005a0u,
        SrgbLinear = 0x12000500u,
        Hdr10 = 0x12002600u,
        Jpeg = 0x220004c6u,
        Bt601Limited = 0x211018c6u,
        Bt601Full = 0x221018c6u,
        Bt709Limited = 0x21100421u,
        Bt709Full = 0x22100421u,
        Bt2020Limited = 0x21102609u,
        Bt2020Full = 0x22102609u,
        RgbDefault = Srgb,
        YuvDefault = Bt601Limited,
    }
}

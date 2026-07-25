using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum GLAttr : uint
    {
        RedSize,
        GreenSize,
        BlueSize,
        AlphaSize,
        BufferSize,
        Doublebuffer,
        DepthSize,
        StencilSize,
        AccumRedSize,
        AccumGreenSize,
        AccumBlueSize,
        AccumAlphaSize,
        Stereo,
        Multisamplebuffers,
        Multisamplesamples,
        AcceleratedVisual,
        RetainedBacking,
        ContextMajorVersion,
        ContextMinorVersion,
        ContextFlags,
        ContextProfileMask,
        ShareWithCurrentContext,
        FramebufferSrgbCapable,
        ContextReleaseBehavior,
        ContextResetNotification,
        ContextNoError,
        Floatbuffers,
        EglPlatform,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUColorTargetDescription
    {
        public GPUTextureFormat Format;
        public GPUColorTargetBlendState BlendState;
    
        public GPUColorTargetDescription(GPUTextureFormat format, GPUColorTargetBlendState blendState)
        {
            this.Format = format;
            this.BlendState = blendState;
        }
    }
}

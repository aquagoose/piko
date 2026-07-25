using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUTextureSamplerBinding
    {
        public GPUTexture Texture;
        public GPUSampler Sampler;
    
        public GPUTextureSamplerBinding(GPUTexture texture, GPUSampler sampler)
        {
            this.Texture = texture;
            this.Sampler = sampler;
        }
    }
}

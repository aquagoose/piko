using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPURasterizerState
    {
        public GPUFillMode FillMode;
        public GPUCullMode CullMode;
        public GPUFrontFace FrontFace;
        public float DepthBiasConstantFactor;
        public float DepthBiasClamp;
        public float DepthBiasSlopeFactor;
        public bool EnableDepthBias;
        public bool EnableDepthClip;
        public byte Padding1;
        public byte Padding2;
    
        public GPURasterizerState(GPUFillMode fillMode, GPUCullMode cullMode, GPUFrontFace frontFace, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor, bool enableDepthBias, bool enableDepthClip, byte padding1, byte padding2)
        {
            this.FillMode = fillMode;
            this.CullMode = cullMode;
            this.FrontFace = frontFace;
            this.DepthBiasConstantFactor = depthBiasConstantFactor;
            this.DepthBiasClamp = depthBiasClamp;
            this.DepthBiasSlopeFactor = depthBiasSlopeFactor;
            this.EnableDepthBias = enableDepthBias;
            this.EnableDepthClip = enableDepthClip;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
        }
    }
}

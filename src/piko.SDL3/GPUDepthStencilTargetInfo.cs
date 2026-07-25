using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUDepthStencilTargetInfo
    {
        public GPUTexture Texture;
        public float ClearDepth;
        public GPULoadOp LoadOp;
        public GPUStoreOp StoreOp;
        public GPULoadOp StencilLoadOp;
        public GPUStoreOp StencilStoreOp;
        public bool Cycle;
        public byte ClearStencil;
        public byte MipLevel;
        public byte Layer;
    
        public GPUDepthStencilTargetInfo(GPUTexture texture, float clearDepth, GPULoadOp loadOp, GPUStoreOp storeOp, GPULoadOp stencilLoadOp, GPUStoreOp stencilStoreOp, bool cycle, byte clearStencil, byte mipLevel, byte layer)
        {
            this.Texture = texture;
            this.ClearDepth = clearDepth;
            this.LoadOp = loadOp;
            this.StoreOp = storeOp;
            this.StencilLoadOp = stencilLoadOp;
            this.StencilStoreOp = stencilStoreOp;
            this.Cycle = cycle;
            this.ClearStencil = clearStencil;
            this.MipLevel = mipLevel;
            this.Layer = layer;
        }
    }
}

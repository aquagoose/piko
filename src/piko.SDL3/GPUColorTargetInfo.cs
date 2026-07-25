using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUColorTargetInfo
    {
        public GPUTexture Texture;
        public uint MipLevel;
        public uint LayerOrDepthPlane;
        public FColor ClearColor;
        public GPULoadOp LoadOp;
        public GPUStoreOp StoreOp;
        public GPUTexture ResolveTexture;
        public uint ResolveMipLevel;
        public uint ResolveLayer;
        public bool Cycle;
        public bool CycleResolveTexture;
        public byte Padding1;
        public byte Padding2;
    
        public GPUColorTargetInfo(GPUTexture texture, uint mipLevel, uint layerOrDepthPlane, FColor clearColor, GPULoadOp loadOp, GPUStoreOp storeOp, GPUTexture resolveTexture, uint resolveMipLevel, uint resolveLayer, bool cycle, bool cycleResolveTexture, byte padding1, byte padding2)
        {
            this.Texture = texture;
            this.MipLevel = mipLevel;
            this.LayerOrDepthPlane = layerOrDepthPlane;
            this.ClearColor = clearColor;
            this.LoadOp = loadOp;
            this.StoreOp = storeOp;
            this.ResolveTexture = resolveTexture;
            this.ResolveMipLevel = resolveMipLevel;
            this.ResolveLayer = resolveLayer;
            this.Cycle = cycle;
            this.CycleResolveTexture = cycleResolveTexture;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
        }
    }
}

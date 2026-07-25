using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUStorageTextureReadWriteBinding
    {
        public GPUTexture Texture;
        public uint MipLevel;
        public uint Layer;
        public bool Cycle;
        public byte Padding1;
        public byte Padding2;
        public byte Padding3;
    
        public GPUStorageTextureReadWriteBinding(GPUTexture texture, uint mipLevel, uint layer, bool cycle, byte padding1, byte padding2, byte padding3)
        {
            this.Texture = texture;
            this.MipLevel = mipLevel;
            this.Layer = layer;
            this.Cycle = cycle;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
            this.Padding3 = padding3;
        }
    }
}

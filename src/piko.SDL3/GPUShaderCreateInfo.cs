using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUShaderCreateInfo
    {
        public nuint CodeSize;
        public byte* Code;
        public sbyte* Entrypoint;
        public GPUShaderFormat Format;
        public GPUShaderStage Stage;
        public uint NumSamplers;
        public uint NumStorageTextures;
        public uint NumStorageBuffers;
        public uint NumUniformBuffers;
        public uint Props;
    
        public GPUShaderCreateInfo(nuint codeSize, byte* code, sbyte* entrypoint, GPUShaderFormat format, GPUShaderStage stage, uint numSamplers, uint numStorageTextures, uint numStorageBuffers, uint numUniformBuffers, uint props)
        {
            this.CodeSize = codeSize;
            this.Code = code;
            this.Entrypoint = entrypoint;
            this.Format = format;
            this.Stage = stage;
            this.NumSamplers = numSamplers;
            this.NumStorageTextures = numStorageTextures;
            this.NumStorageBuffers = numStorageBuffers;
            this.NumUniformBuffers = numUniformBuffers;
            this.Props = props;
        }
    }
}

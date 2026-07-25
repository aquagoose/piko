using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUComputePipelineCreateInfo
    {
        public nuint CodeSize;
        public byte* Code;
        public sbyte* Entrypoint;
        public uint Format;
        public uint NumSamplers;
        public uint NumReadonlyStorageTextures;
        public uint NumReadonlyStorageBuffers;
        public uint NumReadwriteStorageTextures;
        public uint NumReadwriteStorageBuffers;
        public uint NumUniformBuffers;
        public uint ThreadcountX;
        public uint ThreadcountY;
        public uint ThreadcountZ;
        public uint Props;
    
        public GPUComputePipelineCreateInfo(nuint codeSize, byte* code, sbyte* entrypoint, uint format, uint numSamplers, uint numReadonlyStorageTextures, uint numReadonlyStorageBuffers, uint numReadwriteStorageTextures, uint numReadwriteStorageBuffers, uint numUniformBuffers, uint threadcountX, uint threadcountY, uint threadcountZ, uint props)
        {
            this.CodeSize = codeSize;
            this.Code = code;
            this.Entrypoint = entrypoint;
            this.Format = format;
            this.NumSamplers = numSamplers;
            this.NumReadonlyStorageTextures = numReadonlyStorageTextures;
            this.NumReadonlyStorageBuffers = numReadonlyStorageBuffers;
            this.NumReadwriteStorageTextures = numReadwriteStorageTextures;
            this.NumReadwriteStorageBuffers = numReadwriteStorageBuffers;
            this.NumUniformBuffers = numUniformBuffers;
            this.ThreadcountX = threadcountX;
            this.ThreadcountY = threadcountY;
            this.ThreadcountZ = threadcountZ;
            this.Props = props;
        }
    }
}

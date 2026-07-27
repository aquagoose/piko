namespace piko.SDL3.ShaderCross;

// todo structs from another assembly cannot be marshalled. so for now overloads need to be manually written.
public static unsafe partial class SDLShaderCross
{
    public static SDL.GPUShader CompileGraphicsShaderFromSPIRV(SDL.GPUDevice device, SPIRVInfo* info, GraphicsShaderResourceInfo* resourceInfo, uint props)
        => new SDL.GPUShader((nint) CompileGraphicsShaderFromSPIRV((void*) device.Handle, info, resourceInfo, props));

    public static SDL.GPUComputePipeline CompileComputePipelineFromSPIRV(SDL.GPUDevice device, SPIRVInfo* info, ComputePipelineMetadata* metadata, uint props)
        => new SDL.GPUComputePipeline((nint) CompileComputePipelineFromSPIRV((void*) device.Handle, info, metadata, props));
}
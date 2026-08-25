#!/usr/bin/env -S dotnet --
#:property AllowUnsafeBlocks=true
#:project ../../src/piko.SDL3/piko.SDL3.csproj
#:project ../../src/piko.SDL3.ShaderCross/piko.SDL3.ShaderCross.csproj

using System.Runtime.InteropServices;
using piko.SDL3;
using piko.SDL3.ShaderCross;

const string Shader = """
static const float2 Positions[3] = {
    float2(-0.5, -0.5),
    float2( 0.0,  0.5),
    float2( 0.5, -0.5)
};

float4 VSMain(const in uint id: SV_VertexID): SV_Position
{
    return float4(Positions[id], 0.0, 1.0);
}

float4 PSMain(): SV_Target0
{
    return float4(1.0, 0.5, 0.25, 1.0);
}
""";

unsafe
{
    if (!SDL.Init(SDL.InitFlags.Video | SDL.InitFlags.Events))
        throw new Exception($"Failed to initialize SDL: {SDL.GetError()}");

    SDL.Window window = SDL.CreateWindow("GPU Triangle", 800, 600, 0);
    if (window.IsNull)
        throw new Exception($"Failed to create window: {SDL.GetError()}");

    SDL.GPUDevice device = SDL.CreateGPUDevice(SDL.GPUShaderFormat.Spirv | SDL.GPUShaderFormat.Dxbc | SDL.GPUShaderFormat.Msl, false, null);
    if (device.IsNull)
        throw new Exception($"Failed to create device: {SDL.GetError()}");

    if (!SDL.ClaimWindowForGPUDevice(device, window))
        throw new Exception($"Failed to claim window: {SDL.GetError()}");

    SDLShaderCross.Init();

    SDL.GPUShader CreateShader(SDLShaderCross.ShaderStage stage, string hlsl, string entryPoint)
    {
        nint pHlsl = Marshal.StringToHGlobalAnsi(hlsl);
        nint pEntryPoint = Marshal.StringToHGlobalAnsi(entryPoint);

        SDLShaderCross.HLSLInfo hlslInfo = new()
        {
            ShaderStage = stage,
            Source = (sbyte*) pHlsl,
            Entrypoint = (sbyte*) pEntryPoint
        };

        nuint spirvSize;
        void* spirv = SDLShaderCross.CompileSPIRVFromHLSL(&hlslInfo, &spirvSize);
        if (spirv == null)
            throw new Exception($"Failed to compile HLSL: {SDL.GetError()}");

        SDLShaderCross.SPIRVInfo spirvInfo = new()
        {
            ShaderStage = stage,
            Bytecode = (byte*) spirv,
            BytecodeSize = spirvSize,
            Entrypoint = (sbyte*) pEntryPoint
        };

        SDLShaderCross.GraphicsShaderMetadata* metadata = SDLShaderCross.ReflectGraphicsSPIRV((byte*) spirv, spirvSize, 0);

        SDL.GPUShader shader = SDLShaderCross.CompileGraphicsShaderFromSPIRV(device, &spirvInfo, &metadata->ResourceInfo, 0);
        if (shader.IsNull)
            throw new Exception($"Failed to compile shader: {SDL.GetError()}");

        NativeMemory.Free(spirv);
        Marshal.FreeHGlobal(pEntryPoint);
        Marshal.FreeHGlobal(pHlsl);

        return shader;
    }

    SDL.GPUShader vertexShader = CreateShader(SDLShaderCross.ShaderStage.Vertex, Shader, "VSMain");
    SDL.GPUShader fragmentShader = CreateShader(SDLShaderCross.ShaderStage.Fragment, Shader, "PSMain");

    SDL.GPUColorTargetDescription colorTargetDesc = new()
    {
        Format = SDL.GetGPUSwapchainTextureFormat(device, window)
    };

    SDL.GPUGraphicsPipelineCreateInfo pipelineInfo = new()
    {
        VertexShader = vertexShader,
        FragmentShader = fragmentShader,
        PrimitiveType = SDL.GPUPrimitiveType.Trianglelist,
        TargetInfo = new SDL.GPUGraphicsPipelineTargetInfo
        {
            NumColorTargets = 1,
            ColorTargetDescriptions = &colorTargetDesc,
            HasDepthStencilTarget = false
        }
    };

    SDL.GPUGraphicsPipeline pipeline = SDL.CreateGPUGraphicsPipeline(device, &pipelineInfo);
    if (pipeline.IsNull)
        throw new Exception($"Failed to create pipeline: {SDL.GetError}");

    SDL.ReleaseGPUShader(device, fragmentShader);
    SDL.ReleaseGPUShader(device, vertexShader);

    bool alive = true;
    while (alive)
    {
        while (SDL.PollEvent(out SDL.Event sdlEvent))
        {
            switch ((SDL.EventType) sdlEvent.Type)
            {
                case SDL.EventType.Quit:
                case SDL.EventType.WindowCloseRequested:
                    alive = false;
                    break;
            }
        }

        SDL.GPUCommandBuffer cb = SDL.AcquireGPUCommandBuffer(device);
        if (cb.IsNull)
            throw new Exception($"Failed to acquire command buffer: {SDL.GetError()}");

        if (!SDL.WaitAndAcquireGPUSwapchainTexture(cb, window, out SDL.GPUTexture swapchainTexture, out _, out _))
            throw new Exception($"Failed to acquire swapchain texture: {SDL.GetError()}");

        if (swapchainTexture.IsNull)
        {
            SDL.CancelGPUCommandBuffer(cb);
            return;
        }

        SDL.GPUColorTargetInfo colorTarget = new()
        {
            Texture = swapchainTexture,
            ClearColor = new SDL.FColor(0.2f, 0.3f, 0.4f, 1.0f),
            LoadOp = SDL.GPULoadOp.Clear,
            StoreOp = SDL.GPUStoreOp.Store
        };
        SDL.GPURenderPass pass = SDL.BeginGPURenderPass(cb, [colorTarget], null);
        if (pass.IsNull)
            throw new Exception($"Failed to begin render pass: {SDL.GetError()}");

        SDL.BindGPUGraphicsPipeline(pass, pipeline);
        SDL.DrawGPUPrimitives(pass, 3, 1, 0, 0);

        SDL.EndGPURenderPass(pass);
        if (!SDL.SubmitGPUCommandBuffer(cb))
            throw new Exception($"Failed to submit command buffer: {SDL.GetError()}");
    }

    SDL.WaitForGPUIdle(device);
    SDLShaderCross.Quit();
    SDL.ReleaseWindowFromGPUDevice(device, window);
    SDL.DestroyGPUDevice(device);
    SDL.DestroyWindow(window);
    SDL.Quit();
}

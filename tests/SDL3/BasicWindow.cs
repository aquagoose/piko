#!/usr/bin/env -S dotnet --
#:property AllowUnsafeBlocks=true
#:project ../../src/piko.SDL3/piko.SDL3.csproj

using piko.SDL3;

if (!SDL.Init(SDL.InitFlags.Video | SDL.InitFlags.Events))
    throw new Exception($"Failed to initialize SDL: {SDL.GetError()}");

SDL.Window window = SDL.CreateWindow("piko.SDL3.Tests.BasicWindow", 1280, 720, SDL.WindowFlags.Resizable);
if (window.IsNull)
    throw new Exception($"Failed to create window: {SDL.GetError()}");

// todo debugMode is a byte?
// todo name should be nullable or something
SDL.GPUDevice device = SDL.CreateGPUDevice(SDL.GPUShaderFormat.Spirv | SDL.GPUShaderFormat.Msl, false, null);
if (device.IsNull)
    throw new Exception($"Failed to create device: {SDL.GetError()}");

uint props = SDL.GetGPUDeviceProperties(device);
Console.WriteLine(SDL.GetStringProperty(props, SDL.Prop.GpuDeviceNameString, ""));
Console.WriteLine(SDL.GetStringProperty(props, SDL.Prop.GpuDeviceDriverInfoString, ""));
Console.WriteLine(SDL.GetGPUDeviceDriver(device));

if (!SDL.ClaimWindowForGPUDevice(device, window))
    throw new Exception($"Failed to claim window for device: {SDL.GetError()}");

bool alive = true;
while (alive)
{
    while (SDL.PollEvent(out SDL.Event winEvent))
    {
        // todo: manual clause for EventType in here?
        switch ((SDL.EventType) winEvent.Type)
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

    SDL.WaitAndAcquireGPUSwapchainTexture(cb, window, out SDL.GPUTexture texture, out _, out _);
    if (texture.IsNull)
    {
        SDL.CancelGPUCommandBuffer(cb);
        continue;
    }

    SDL.GPUColorTargetInfo target = new()
    {
        Texture = texture,
        ClearColor = new SDL.FColor(1.0f, 0.5f, 0.25f, 1.0f),
        LoadOp = SDL.GPULoadOp.Clear,
        StoreOp = SDL.GPUStoreOp.Store
    };

    SDL.GPURenderPass pass = SDL.BeginGPURenderPass(cb, [target], null);
    SDL.EndGPURenderPass(pass);

    SDL.SubmitGPUCommandBuffer(cb);
}

SDL.ReleaseWindowFromGPUDevice(device, window);
SDL.DestroyGPUDevice(device);
SDL.DestroyWindow(window);
SDL.Quit();

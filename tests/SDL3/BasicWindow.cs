#!/usr/bin/env -S dotnet --
#:property AllowUnsafeBlocks=true
#:project ../../src/piko.SDL3/piko.SDL3.csproj

using piko.SDL3;

unsafe
{
    // todo no SDL.InitFlags
    if (!SDL.Init(0x20 | 0x4000))
        throw new Exception($"Failed to initialize SDL: {SDL.GetError()}");

    // todo no SDL.WindowFlags
    SDL.Window window = SDL.CreateWindow("piko.SDL3.Tests.BasicWindow", 1280, 720, 0);
    if (window.IsNull)
        throw new Exception($"Failed to create window: {SDL.GetError()}");

    // todo no SDL.GPUShaderFormat
    // todo debugMode is a byte?
    // todo name should be nullable or something
    SDL.GPUDevice device = SDL.CreateGPUDevice((1u << 1) | (1u << 4), 0, null);
    if (device.IsNull)
        throw new Exception($"Failed to create device: {SDL.GetError()}");
    if (!SDL.ClaimWindowForGPUDevice(device, window))
        throw new Exception($"Failed to claim window for device: {SDL.GetError()}");

    bool alive = true;
    while (alive)
    {
        // todo should be out or ref
        SDL.Event winEvent;
        while (SDL.PollEvent(&winEvent))
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
        // todo i had to manually add "out" to the bindings as it didn't generate as a pointer at all, which is invalid
        // todo the last 2 parameters should be out or ref. or both!
        SDL.AcquireGPUSwapchainTexture(cb, window, out SDL.GPUTexture texture, null, null);

        SDL.GPUColorTargetInfo target = new()
        {
            Texture = texture,
            ClearColor = new SDL.FColor(1.0f, 0.5f, 0.25f, 1.0f),
            LoadOp = SDL.GPULoadOp.Clear,
            StoreOp = SDL.GPUStoreOp.Store
        };

        // todo: span overload
        SDL.GPURenderPass pass = SDL.BeginGPURenderPass(cb, &target, 1, null);
        SDL.EndGPURenderPass(pass);
        
        SDL.SubmitGPUCommandBuffer(cb);
    }

    SDL.ReleaseWindowFromGPUDevice(device, window);
    SDL.DestroyGPUDevice(device);
    SDL.DestroyWindow(window);
    SDL.Quit();
}
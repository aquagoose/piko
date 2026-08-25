using System.Runtime.CompilerServices;

namespace piko.SDL3;

public static unsafe partial class SDL
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint WindowPosCenteredDisplay(uint x)
        => WindowposCenteredMask | x;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool PollEvent(out Event @event)
    {
        fixed (Event* pEvent = &@event)
            return PollEvent(pEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool WaitEvent(out Event @event)
    {
        fixed (Event* pEvent = &@event)
            return WaitEvent(pEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool WaitEventTimeout(out Event @event, int timeoutms)
    {
        fixed (Event* pEvent = &@event)
            return WaitEventTimeout(pEvent, timeoutms);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool GetWindowSize(Window window, out int w, out int h)
    {
        fixed (int* pW = &w)
        fixed (int* pH = &h)
            return GetWindowSize(window, pW, pH);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool GetWindowSizeInPixels(Window window, out int w, out int h)
    {
        fixed (int* pW = &w)
        fixed (int* pH = &h)
            return GetWindowSizeInPixels(window, pW, pH);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, out GPUTexture swapchainTexture, out uint swapchainTextureWidth, out uint swapchainTextureHeight)
    {
        fixed (GPUTexture* pTexture = &swapchainTexture)
        fixed (uint* pW = &swapchainTextureWidth)
        fixed (uint* pH = &swapchainTextureHeight)
            return AcquireGPUSwapchainTexture(commandBuffer, window, pTexture, pW, pH);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool WaitAndAcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, out GPUTexture swapchainTexture, out uint swapchainTextureWidth, out uint swapchainTextureHeight)
    {
        fixed (GPUTexture* pTexture = &swapchainTexture)
        fixed (uint* pW = &swapchainTextureWidth)
        fixed (uint* pH = &swapchainTextureHeight)
            return WaitAndAcquireGPUSwapchainTexture(commandBuffer, window, pTexture, pW, pH);
    }

    public static GPURenderPass BeginGPURenderPass(GPUCommandBuffer commandBuffer, ReadOnlySpan<GPUColorTargetInfo> colorTargetInfos, GPUDepthStencilTargetInfo? depthStencilTargetInfo)
    {
        GPUDepthStencilTargetInfo depthTarget = depthStencilTargetInfo.GetValueOrDefault();
        fixed (GPUColorTargetInfo* pTargets = colorTargetInfos)
            return BeginGPURenderPass(commandBuffer, pTargets, (uint) colorTargetInfos.Length, depthStencilTargetInfo.HasValue ? &depthTarget : null);
    }
}

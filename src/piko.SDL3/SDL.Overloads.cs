using System.Runtime.CompilerServices;

namespace piko.SDL3;

public static unsafe partial class SDL
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint WindowPosCenteredDisplay(uint x)
        => WindowposCenteredMask | x;

    public static bool CreateWindowAndRenderer(string title, int width, int height, WindowFlags windowFlags, out SDL.Window window, out SDL.Renderer renderer)
    {
        fixed (SDL.Window* pWindow = &window)
        fixed (SDL.Renderer* pRenderer = &renderer)
            return CreateWindowAndRenderer(title, width, height, windowFlags, pWindow, pRenderer);
    }

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
            return BeginGPURenderPass(commandBuffer, pTargets, (uint) colorTargetInfos.Length, depthStencilTargetInfo == null ? null : &depthTarget);
    }

    public static bool GetCurrentRenderOutputSize(Renderer renderer, out int w, out int h)
    {
        fixed (int* pW = &w)
        fixed (int* pH = &h)
            return GetCurrentRenderOutputSize(renderer, pW, pH);
    }

    public static bool GetRenderClipRect(Renderer renderer, out Rect rect)
    {
        fixed (Rect* pRect = &rect)
            return GetRenderClipRect(renderer, pRect);
    }

    public static bool GetRenderViewport(Renderer renderer, out Rect rect)
    {
        fixed (Rect* pRect = &rect)
            return GetRenderViewport(renderer, pRect);
    }

    public static bool RenderFillRect(Renderer renderer, in FRect? rect)
    {
        FRect r = rect.GetValueOrDefault();
        return RenderFillRect(renderer, rect == null ? null : &r);
    }

    public static bool RenderFillRects(Renderer renderer, ReadOnlySpan<FRect> rects)
    {
        fixed (FRect* pRects = rects)
            return RenderFillRects(renderer, pRects, rects.Length);
    }

    public static bool RenderGeometry(Renderer renderer, Texture texture, ReadOnlySpan<Vertex> vertices, ReadOnlySpan<int> indices)
    {
        fixed (Vertex* pVertices = vertices)
        fixed (int* pIndices = indices)
            return RenderGeometry(renderer, texture, pVertices, vertices.Length, pIndices, indices.Length);
    }

    public static bool RenderGeometry(Renderer renderer, Texture texture, ReadOnlySpan<Vertex> vertices)
    {
        fixed (Vertex* pVertices = vertices)
            return RenderGeometry(renderer, texture, pVertices, vertices.Length, null, 0);
    }

    // todo RenderGeometryRaw. it's got quite a complex signature so will be ignored for now

    public static bool RenderLines(Renderer renderer, ReadOnlySpan<FPoint> points)
    {
        fixed (FPoint* pPoints = points)
            return RenderLines(renderer, pPoints, points.Length);
    }

    public static bool RenderPoints(Renderer renderer, ReadOnlySpan<FPoint> points)
    {
        fixed (FPoint* pPoints = points)
            return RenderPoints(renderer, pPoints, points.Length);
    }

    public static Surface RenderReadPixels(Renderer renderer, in Rect? rect)
    {
        Rect r = rect.GetValueOrDefault();
        return RenderReadPixels(renderer, rect == null ? null : &r);
    }

    public static bool RenderRect(Renderer renderer, in FRect? rect)
    {
        FRect r = rect.GetValueOrDefault();
        return RenderRect(renderer, rect == null ? null : &r);
    }

    public static bool RenderRects(Renderer renderer, ReadOnlySpan<FRect> rects)
    {
        fixed (FRect* pRects = rects)
            return RenderRects(renderer, pRects, rects.Length);
    }

    public static bool RenderTexture(Renderer renderer, Texture texture, in FRect? srcRect, in FRect? dstRect)
    {
        FRect src = srcRect.GetValueOrDefault();
        FRect dst = dstRect.GetValueOrDefault();
        return RenderTexture(renderer, texture, srcRect == null ? null : &src, dstRect == null ? null : &dst);
    }

    public static bool RenderTexture9Grid(Renderer renderer, Texture texture, in FRect? srcRect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, in FRect? dstRect)
    {
        FRect src = srcRect.GetValueOrDefault();
        FRect dst = dstRect.GetValueOrDefault();
        return RenderTexture9Grid(renderer, texture, srcRect == null ? null : &src, leftWidth, rightWidth, topHeight, bottomHeight, scale, dstRect == null ? null : &dst);
    }

    public static bool RenderTexture9GridTiled(Renderer renderer, Texture texture, in FRect? srcRect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, in FRect? dstRect, float tileScale)
    {
        FRect src = srcRect.GetValueOrDefault();
        FRect dst = dstRect.GetValueOrDefault();
        return RenderTexture9GridTiled(renderer, texture, srcRect == null ? null : &src, leftWidth, rightWidth, topHeight, bottomHeight, scale, dstRect == null ? null : &dst, tileScale);
    }

    public static bool RenderTextureRotated(Renderer renderer, Texture texture, in FRect? srcRect, in FRect? dstRect, double angle, in FPoint? center, FlipMode flip)
    {
        FRect src = srcRect.GetValueOrDefault();
        FRect dst = dstRect.GetValueOrDefault();
        FPoint c = center.GetValueOrDefault();
        return RenderTextureRotated(renderer, texture, srcRect == null ? null : &src, dstRect == null ? null : &dst, angle, center == null ? null : &c, flip);
    }

    public static bool RenderTextureTiled(Renderer renderer, Texture texture, in FRect? srcRect, float scale, in FRect? dstRect)
    {
        FRect src = srcRect.GetValueOrDefault();
        FRect dst = dstRect.GetValueOrDefault();
        return RenderTextureTiled(renderer, texture, srcRect == null ? null : &src, scale, dstRect == null ? null : &dst);
    }

    public static bool SetRenderClipRect(Renderer renderer, in Rect? rect)
    {
        Rect r = rect.GetValueOrDefault();
        return SetRenderClipRect(renderer, rect == null ? null : r);
    }

    public static bool SetRenderViewport(Renderer renderer, in Rect? rect)
    {
        Rect r = rect.GetValueOrDefault();
        return SetRenderViewport(renderer, rect == null ? null : r);
    }
}

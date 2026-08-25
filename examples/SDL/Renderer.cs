#!/usr/bin/env -S dotnet --
#:property AllowUnsafeBlocks=true
#:project ../../src/piko.SDL3/piko.SDL3.csproj

using System.Diagnostics;
using piko.SDL3;

if (!SDL.Init(SDL.InitFlags.Video | SDL.InitFlags.Events))
    throw new Exception($"Failed to initialize SDL: {SDL.GetError()}");

if (!SDL.CreateWindowAndRenderer("Renderer Example", 800, 600, SDL.WindowFlags.Resizable, out SDL.Window window, out SDL.Renderer renderer))
    throw new Exception($"Failed to create window or renderer: {SDL.GetError()}");

SDL.Surface surface = SDL.LoadPNG("Content/DEBUG.png");
if (surface.IsNull)
    throw new Exception($"Failed to load PNG: {SDL.GetError()}");

SDL.Texture texture = SDL.CreateTextureFromSurface(renderer, surface);
if (texture.IsNull)
    throw new Exception($"Failed to create texture: {SDL.GetError()}");
Console.WriteLine($"{texture.W}x{texture.H}: {texture.Format}");

Stopwatch sw = Stopwatch.StartNew();

float angle = 0;
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

    float dt = (float) sw.Elapsed.TotalSeconds;
    sw.Restart();

    angle += 60 * dt;
    if (angle >= 360)
        angle -= 360;

    SDL.SetRenderDrawColorFloat(renderer, 0.2f, 0.3f, 0.4f, 1.0f);
    SDL.RenderClear(renderer);

    for (int i = 0; i < 20; i++)
    {
        int mulAmount = i > 9 ? 19 - i : i;
        SDL.FRect dest = new SDL.FRect(mulAmount * 70, i * 20, texture.W, texture.H);
        SDL.RenderTextureRotated(renderer, texture, null, dest, angle + i * 50, null, SDL.FlipMode.None);
    }

    SDL.RenderPresent(renderer);
}

SDL.DestroyRenderer(renderer);
SDL.DestroyWindow(window);
SDL.Quit();

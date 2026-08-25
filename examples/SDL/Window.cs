#!/usr/bin/env -S dotnet --
#:project ../../src/piko.SDL3/piko.SDL3.csproj

using piko.SDL3;

// Initialize SDL. SDL must be initialized before most functions can be used. Windowing is part of the video subsystem.
// We also initialize the events subsystem, although this isn't strictly necessary.
if (!SDL.Init(SDL.InitFlags.Video | SDL.InitFlags.Events))
    throw new Exception($"Failed to initialize SDL: {SDL.GetError()}");

// Create a window, passing in a "Resizable" flag to make the window resizable.
// Flags are not required, and a 0 can be passed if no flags are desired.
SDL.Window window = SDL.CreateWindow("Basic Window Example", 800, 600, SDL.WindowFlags.Resizable);
// Check that window creation was successful. If unsuccessful, SDL will provide a null value.
if (window.IsNull)
    throw new Exception($"Failed to create SDL window: {SDL.GetError()}");

// Create a SDL3 renderer.
// For the purposes of this demo, this is purely to get the window to show up.
// On some platforms such as Wayland, a window will not display unless there is some kind of presentation from a renderer,
// such as OpenGL, Vulkan, or, in this case, the SDL3 renderer.
SDL.Renderer renderer = SDL.CreateRenderer(window, null);
// Check that the renderer creation was successful.
if (renderer.IsNull)
    throw new Exception($"Failed to create SDL renderer: {SDL.GetError()}");

// Main loop
bool alive = true;
while (alive)
{
    // Poll all events.
    // You must do this in some capacity, otherwise the OS will think that the window is frozen and will display a "not responding" message.
    while (SDL.PollEvent(out SDL.Event sdlEvent))
    {
        switch ((SDL.EventType) sdlEvent.Type)
        {
            // Handle window close events. The quit event is sent from some OSes, such as macOS, when cmd+q is pressed.
            case SDL.EventType.Quit:
            case SDL.EventType.WindowCloseRequested:
                alive = false;
                break;
        }
    }

    // Clear the window to a orange color.
    SDL.SetRenderDrawColor(renderer, 255, 128, 64, 255);
    SDL.RenderClear(renderer);

    // Present to the window. We must do this to get the window to display on some platforms such as wayland!
    SDL.RenderPresent(renderer);
}

// Free the resources.
SDL.DestroyRenderer(renderer);
SDL.DestroyWindow(window);
SDL.Quit();

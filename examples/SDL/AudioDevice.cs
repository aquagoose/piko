#!/usr/bin/env -S dotnet --
#:property AllowUnsafeBlocks=true
#:project ../../src/piko.SDL3/piko.SDL3.csproj

using System.Runtime.InteropServices;
using piko.SDL3;

unsafe
{
    if (!SDL.Init(SDL.InitFlags.Audio))
        throw new Exception($"Failed to initialize SDL: {SDL.GetError()}");

    SDL.AudioSpec spec = new()
    {
        Format = SDL.AudioFormat.F32,
        Freq = 44100,
        Channels = 2
    };
    uint audioDevice = SDL.OpenAudioDevice(SDL.AudioDeviceDefaultPlayback, &spec);
    if (audioDevice == 0)
        throw new Exception($"Failed to open audio device: {SDL.GetError()}");

    SDL.AudioSpec wavSpec;
    byte* wavBuffer;
    uint wavLength;
    SDL.LoadWAV("Content/Song.wav", &wavSpec, &wavBuffer, &wavLength);

    SDL.AudioStream stream = SDL.CreateAudioStream(&wavSpec, null);
    SDL.BindAudioStream(audioDevice, stream);
    SDL.PutAudioStreamData(stream, (nint) wavBuffer, (int) wavLength);

    NativeMemory.Free(wavBuffer);

    SDL.ResumeAudioDevice(audioDevice);

    while (SDL.GetAudioStreamAvailable(stream) > 0)
    {
        Thread.Sleep(1000);
    }

    SDL.PauseAudioDevice(audioDevice);
    SDL.UnbindAudioStream(stream);
    SDL.DestroyAudioStream(stream);
    SDL.CloseAudioDevice(audioDevice);
}

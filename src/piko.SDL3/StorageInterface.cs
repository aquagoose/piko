using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct StorageInterface
    {
        public uint Version;
        public delegate* unmanaged[Cdecl]<void*, byte> Close;
        public delegate* unmanaged[Cdecl]<void*, byte> Ready;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult>, void*, byte> Enumerate;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, SDL_PathInfo*, byte> Info;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, void*, nuint, byte> ReadFile;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, void*, nuint, byte> WriteFile;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, byte> Mkdir;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, byte> Remove;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, byte> Rename;
        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, byte> Copy;
        public delegate* unmanaged[Cdecl]<void*, nuint> SpaceRemaining;
    
        public StorageInterface(uint version, delegate* unmanaged[Cdecl]<void*, byte> close, delegate* unmanaged[Cdecl]<void*, byte> ready, delegate* unmanaged[Cdecl]<void*, sbyte*, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult>, void*, byte> enumerate, delegate* unmanaged[Cdecl]<void*, sbyte*, SDL_PathInfo*, byte> info, delegate* unmanaged[Cdecl]<void*, sbyte*, void*, nuint, byte> readFile, delegate* unmanaged[Cdecl]<void*, sbyte*, void*, nuint, byte> writeFile, delegate* unmanaged[Cdecl]<void*, sbyte*, byte> mkdir, delegate* unmanaged[Cdecl]<void*, sbyte*, byte> remove, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, byte> rename, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, byte> copy, delegate* unmanaged[Cdecl]<void*, nuint> spaceRemaining)
        {
            this.Version = version;
            this.Close = close;
            this.Ready = ready;
            this.Enumerate = enumerate;
            this.Info = info;
            this.ReadFile = readFile;
            this.WriteFile = writeFile;
            this.Mkdir = mkdir;
            this.Remove = remove;
            this.Rename = rename;
            this.Copy = copy;
            this.SpaceRemaining = spaceRemaining;
        }
    }
}

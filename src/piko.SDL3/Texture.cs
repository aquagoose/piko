using System.Runtime.InteropServices;
using piko.Core;

namespace piko.SDL3;

public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Texture : IHandle
    {
        private readonly TextureRef* _ref;

        public nint Handle => (nint) _ref;
        public bool IsNull => _ref == null;

        public ref PixelFormat Format => ref _ref->Format;
        public ref int W => ref _ref->W;
        public ref int H => ref _ref->H;
        public ref int RefCount => ref _ref->Refcount;

        public Texture(TextureRef* @ref)
        {
            _ref = @ref;
        }
    }
}

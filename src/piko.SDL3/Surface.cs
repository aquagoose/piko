using System.Runtime.InteropServices;
using piko.Core;

namespace piko.SDL3;

public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Surface : IHandle
    {
        private readonly SurfaceRef* _ref;

        public nint Handle => (nint) _ref;
        public bool IsNull => _ref == null;

        public ref uint Flags => ref _ref->Flags;
        public ref PixelFormat Format => ref _ref->Format;
        public ref int W => ref _ref->W;
        public ref int H => ref _ref->H;
        public ref int Pitch => ref _ref->Pitch;
        public ref nint Pixels => ref _ref->Pixels;
        public ref int RefCount => ref _ref->Refcount;

        public Surface(SurfaceRef* @ref)
        {
            _ref = @ref;
        }
    }
}

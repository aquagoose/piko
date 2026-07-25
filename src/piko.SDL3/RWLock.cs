using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RWLock
    {
        private readonly nint _handle;
    
        public nint Handle => _handle;
        public bool IsNull => _handle == 0;
    
        public RWLock(nint handle)
        {
            _handle = handle;
        }
    
        public static implicit operator bool(RWLock s)
             => !s.IsNull;
    }
}

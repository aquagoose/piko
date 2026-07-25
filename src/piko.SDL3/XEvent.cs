using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct XEvent
    {
        private readonly nint _handle;
    
        public nint Handle => _handle;
        public bool IsNull => _handle == 0;
    
        public XEvent(nint handle)
        {
            _handle = handle;
        }
    
        public static implicit operator bool(XEvent s)
             => !s.IsNull;
    }
}

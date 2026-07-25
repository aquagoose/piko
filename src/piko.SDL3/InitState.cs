using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct InitState
    {
        public AtomicInt Status;
        public nuint Thread;
        public void* Reserved;
    
        public InitState(AtomicInt status, nuint thread, void* reserved)
        {
            this.Status = status;
            this.Thread = thread;
            this.Reserved = reserved;
        }
    }
}

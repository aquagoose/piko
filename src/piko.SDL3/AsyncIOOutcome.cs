using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AsyncIOOutcome
    {
        public AsyncIO Asyncio;
        public AsyncIOTaskType Type;
        public AsyncIOResult Result;
        public void* Buffer;
        public nuint Offset;
        public nuint BytesRequested;
        public nuint BytesTransferred;
        public void* Userdata;
    
        public AsyncIOOutcome(AsyncIO asyncio, AsyncIOTaskType type, AsyncIOResult result, void* buffer, nuint offset, nuint bytesRequested, nuint bytesTransferred, void* userdata)
        {
            this.Asyncio = asyncio;
            this.Type = type;
            this.Result = result;
            this.Buffer = buffer;
            this.Offset = offset;
            this.BytesRequested = bytesRequested;
            this.BytesTransferred = bytesTransferred;
            this.Userdata = userdata;
        }
    }
}

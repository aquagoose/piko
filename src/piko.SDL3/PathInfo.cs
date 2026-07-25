using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PathInfo
    {
        public PathType Type;
        public nuint Size;
        public nint CreateTime;
        public nint ModifyTime;
        public nint AccessTime;
    
        public PathInfo(PathType type, nuint size, nint createTime, nint modifyTime, nint accessTime)
        {
            this.Type = type;
            this.Size = size;
            this.CreateTime = createTime;
            this.ModifyTime = modifyTime;
            this.AccessTime = accessTime;
        }
    }
}

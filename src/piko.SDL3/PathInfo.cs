using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PathInfo
    {
        public PathType Type;
        public ulong Size;
        public long CreateTime;
        public long ModifyTime;
        public long AccessTime;
    
        public PathInfo(PathType type, ulong size, long createTime, long modifyTime, long accessTime)
        {
            this.Type = type;
            this.Size = size;
            this.CreateTime = createTime;
            this.ModifyTime = modifyTime;
            this.AccessTime = accessTime;
        }
    }
}

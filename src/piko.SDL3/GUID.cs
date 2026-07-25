using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GUID
    {
        public byte Data;
    
        public GUID(byte data)
        {
            this.Data = data;
        }
    }
}

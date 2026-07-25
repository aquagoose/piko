using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DialogFileFilter
    {
        public sbyte* Name;
        public sbyte* Pattern;
    
        public DialogFileFilter(sbyte* name, sbyte* pattern)
        {
            this.Name = name;
            this.Pattern = pattern;
        }
    }
}

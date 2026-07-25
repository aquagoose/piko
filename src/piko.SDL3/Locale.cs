using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Locale
    {
        public sbyte* Language;
        public sbyte* Country;
    
        public Locale(sbyte* language, sbyte* country)
        {
            this.Language = language;
            this.Country = country;
        }
    }
}

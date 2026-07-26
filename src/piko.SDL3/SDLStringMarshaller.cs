using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace piko.SDL3;

public static unsafe partial class SDL
{
    // From https://github.com/flibitijibibo/SDL3-CS/
    // SDL strings especially on return values don't seem to work right with C# strings.
    // This seems to fix that.
    [CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(StringMarshaller))]
    internal static class StringMarshaller
    {
        public static string ConvertToManaged(byte* unmanaged)
            => Marshal.PtrToStringUTF8((nint) unmanaged);
    }
}
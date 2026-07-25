using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public enum HidBusType : uint
    {
        HidApiBusUnknown = 0x00,
        HidApiBusUsb = 0x01,
        HidApiBusBluetooth = 0x02,
        HidApiBusI2c = 0x03,
        HidApiBusSpi = 0x04,
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HidDeviceInfo
    {
        public sbyte* Path;
        public ushort VendorId;
        public ushort ProductId;
        public uint* SerialNumber;
        public ushort ReleaseNumber;
        public uint* ManufacturerString;
        public uint* ProductString;
        public ushort UsagePage;
        public ushort Usage;
        public int InterfaceNumber;
        public int InterfaceClass;
        public int InterfaceSubclass;
        public int InterfaceProtocol;
        public HidBusType BusType;
        public HidDeviceInfo* Next;
    
        public HidDeviceInfo(sbyte* path, ushort vendorId, ushort productId, uint* serialNumber, ushort releaseNumber, uint* manufacturerString, uint* productString, ushort usagePage, ushort usage, int interfaceNumber, int interfaceClass, int interfaceSubclass, int interfaceProtocol, HidBusType busType, HidDeviceInfo* next)
        {
            this.Path = path;
            this.VendorId = vendorId;
            this.ProductId = productId;
            this.SerialNumber = serialNumber;
            this.ReleaseNumber = releaseNumber;
            this.ManufacturerString = manufacturerString;
            this.ProductString = productString;
            this.UsagePage = usagePage;
            this.Usage = usage;
            this.InterfaceNumber = interfaceNumber;
            this.InterfaceClass = interfaceClass;
            this.InterfaceSubclass = interfaceSubclass;
            this.InterfaceProtocol = interfaceProtocol;
            this.BusType = busType;
            this.Next = next;
        }
    }
}

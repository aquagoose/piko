using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SensorEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint Which;
        public float Data;
        public ulong SensorTimestamp;
    
        public SensorEvent(EventType type, uint reserved, ulong timestamp, uint which, float data, ulong sensorTimestamp)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.Data = data;
            this.SensorTimestamp = sensorTimestamp;
        }
    }
}

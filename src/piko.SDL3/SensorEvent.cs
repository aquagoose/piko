using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SensorEvent
    {
        public EventType Type;
        public uint Reserved;
        public nuint Timestamp;
        public uint Which;
        public float Data;
        public nuint SensorTimestamp;
    
        public SensorEvent(EventType type, uint reserved, nuint timestamp, uint which, float data, nuint sensorTimestamp)
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

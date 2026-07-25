using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GamepadSensorEvent
    {
        public EventType Type;
        public uint Reserved;
        public ulong Timestamp;
        public uint Which;
        public int Sensor;
        public float Data;
        public ulong SensorTimestamp;
    
        public GamepadSensorEvent(EventType type, uint reserved, ulong timestamp, uint which, int sensor, float data, ulong sensorTimestamp)
        {
            this.Type = type;
            this.Reserved = reserved;
            this.Timestamp = timestamp;
            this.Which = which;
            this.Sensor = sensor;
            this.Data = data;
            this.SensorTimestamp = sensorTimestamp;
        }
    }
}

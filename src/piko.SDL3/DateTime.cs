using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DateTime
    {
        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public int Second;
        public int Nanosecond;
        public int DayOfWeek;
        public int UtcOffset;
    
        public DateTime(int year, int month, int day, int hour, int minute, int second, int nanosecond, int dayOfWeek, int utcOffset)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
            this.Nanosecond = nanosecond;
            this.DayOfWeek = dayOfWeek;
            this.UtcOffset = utcOffset;
        }
    }
}

using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AssertData
    {
        public bool AlwaysIgnore;
        public uint TriggerCount;
        public sbyte* Condition;
        public sbyte* Filename;
        public int Linenum;
        public sbyte* Function;
        public AssertData* Next;
    
        public AssertData(bool alwaysIgnore, uint triggerCount, sbyte* condition, sbyte* filename, int linenum, sbyte* function, AssertData* next)
        {
            this.AlwaysIgnore = alwaysIgnore;
            this.TriggerCount = triggerCount;
            this.Condition = condition;
            this.Filename = filename;
            this.Linenum = linenum;
            this.Function = function;
            this.Next = next;
        }
    }
}

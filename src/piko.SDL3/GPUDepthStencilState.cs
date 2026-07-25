using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUDepthStencilState
    {
        public GPUCompareOp CompareOp;
        public GPUStencilOpState BackStencilState;
        public GPUStencilOpState FrontStencilState;
        public byte CompareMask;
        public byte WriteMask;
        public bool EnableDepthTest;
        public bool EnableDepthWrite;
        public bool EnableStencilTest;
        public byte Padding1;
        public byte Padding2;
        public byte Padding3;
    
        public GPUDepthStencilState(GPUCompareOp compareOp, GPUStencilOpState backStencilState, GPUStencilOpState frontStencilState, byte compareMask, byte writeMask, bool enableDepthTest, bool enableDepthWrite, bool enableStencilTest, byte padding1, byte padding2, byte padding3)
        {
            this.CompareOp = compareOp;
            this.BackStencilState = backStencilState;
            this.FrontStencilState = frontStencilState;
            this.CompareMask = compareMask;
            this.WriteMask = writeMask;
            this.EnableDepthTest = enableDepthTest;
            this.EnableDepthWrite = enableDepthWrite;
            this.EnableStencilTest = enableStencilTest;
            this.Padding1 = padding1;
            this.Padding2 = padding2;
            this.Padding3 = padding3;
        }
    }
}

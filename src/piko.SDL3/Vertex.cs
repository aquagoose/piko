using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Vertex
    {
        public FPoint Position;
        public FColor Color;
        public FPoint TexCoord;
    
        public Vertex(FPoint position, FColor color, FPoint texCoord)
        {
            this.Position = position;
            this.Color = color;
            this.TexCoord = texCoord;
        }
    }
}

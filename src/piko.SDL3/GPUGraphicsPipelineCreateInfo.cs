using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GPUGraphicsPipelineCreateInfo
    {
        public GPUShader VertexShader;
        public GPUShader FragmentShader;
        public GPUVertexInputState VertexInputState;
        public GPUPrimitiveType PrimitiveType;
        public GPURasterizerState RasterizerState;
        public GPUMultisampleState MultisampleState;
        public GPUDepthStencilState DepthStencilState;
        public GPUGraphicsPipelineTargetInfo TargetInfo;
        public uint Props;
    
        public GPUGraphicsPipelineCreateInfo(GPUShader vertexShader, GPUShader fragmentShader, GPUVertexInputState vertexInputState, GPUPrimitiveType primitiveType, GPURasterizerState rasterizerState, GPUMultisampleState multisampleState, GPUDepthStencilState depthStencilState, GPUGraphicsPipelineTargetInfo targetInfo, uint props)
        {
            this.VertexShader = vertexShader;
            this.FragmentShader = fragmentShader;
            this.VertexInputState = vertexInputState;
            this.PrimitiveType = primitiveType;
            this.RasterizerState = rasterizerState;
            this.MultisampleState = multisampleState;
            this.DepthStencilState = depthStencilState;
            this.TargetInfo = targetInfo;
            this.Props = props;
        }
    }
}

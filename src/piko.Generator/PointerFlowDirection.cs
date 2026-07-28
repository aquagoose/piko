namespace piko.Generator;

public enum PointerFlowDirection
{
    /// <summary>
    /// Unknown flow direction. Either this is not a pointer, or a standard pointer will be generated for these.
    /// </summary>
    None = 0,

    /// <summary>
    /// An 'in' parameter will be generated.
    /// </summary>
    In,

    /// <summary>
    /// An 'out' parameter will be generated.
    /// </summary>
    Out,

    /// <summary>
    /// A 'ref' parameter will be generated.
    /// </summary>
    InAndOut
}
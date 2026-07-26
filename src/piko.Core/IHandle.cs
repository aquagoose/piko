namespace piko.Core;

public interface IHandle
{
    /// <summary>
    /// Gets the native handle value.
    /// </summary>
    public nint Handle { get; }

    /// <summary>
    /// Gets if this handle is null.
    /// </summary>
    public bool IsNull { get; }
}
namespace GenericSequenceGenerator;

/// <summary>
/// Represents a stateful generator for a sequence of values.
/// </summary>
/// <typeparam name="T">The type of values in the sequence.</typeparam>
public interface ISequenceGenerator<T>
{
    /// <summary>
    /// Gets the value immediately before <see cref="Current"/>.
    /// </summary>
    T Previous { get; }

    /// <summary>
    /// Gets the current value in the sequence.
    /// </summary>
    T Current { get; }

    /// <summary>
    /// Gets the next value and advances the generator.
    /// </summary>
    T Next { get; }
}

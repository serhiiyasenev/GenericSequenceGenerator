namespace GenericSequenceGenerator;

/// <summary>
/// Provides state management for a sequence defined by its two latest values.
/// </summary>
/// <typeparam name="T">The type of values in the sequence.</typeparam>
public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
{
    private T previous;
    private T current;

    /// <summary>
    /// Initializes a new instance of the <see cref="SequenceGenerator{T}"/> class.
    /// </summary>
    /// <param name="previous">The first value in the sequence.</param>
    /// <param name="current">The second value in the sequence.</param>
    protected SequenceGenerator(T previous, T current)
    {
        this.previous = previous;
        this.current = current;
        this.Count = 2;
    }

    /// <inheritdoc/>
    public T Previous => this.previous;

    /// <inheritdoc/>
    public T Current => this.current;

    /// <summary>
    /// Gets the number of sequence values produced so far, including the two initial values.
    /// </summary>
    public int Count { get; private set; }

    /// <inheritdoc/>
    public T Next
    {
        get
        {
            T next = this.GetNext();
            this.previous = this.current;
            this.current = next;
            this.Count++;
            return next;
        }
    }

    /// <summary>
    /// Calculates the next value from <see cref="Previous"/> and <see cref="Current"/>.
    /// </summary>
    /// <returns>The next value in the sequence.</returns>
    protected abstract T GetNext();
}

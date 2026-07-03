namespace GenericSequenceGenerator;

/// <summary>
/// Generates a sequence using a caller-provided recurrence function.
/// </summary>
/// <typeparam name="T">The type of values in the sequence.</typeparam>
public sealed class DelegateSequenceGenerator<T> : SequenceGenerator<T>
{
    private readonly Func<T, T, T> nextValue;

    /// <summary>
    /// Initializes a new instance of the <see cref="DelegateSequenceGenerator{T}"/> class.
    /// </summary>
    /// <param name="previous">The first sequence value.</param>
    /// <param name="current">The second sequence value.</param>
    /// <param name="nextValue">A function receiving the previous and current values.</param>
    /// <exception cref="ArgumentNullException"><paramref name="nextValue"/> is null.</exception>
    public DelegateSequenceGenerator(T previous, T current, Func<T, T, T> nextValue)
        : base(previous, current)
    {
        ArgumentNullException.ThrowIfNull(nextValue);
        this.nextValue = nextValue;
    }

    /// <inheritdoc/>
    protected override T GetNext() => this.nextValue(this.Previous, this.Current);
}

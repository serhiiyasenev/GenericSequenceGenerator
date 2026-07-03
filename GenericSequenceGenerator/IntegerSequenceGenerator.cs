namespace GenericSequenceGenerator;

/// <summary>
/// Generates integers using x(n+1) = 6*x(n) - 8*x(n-1).
/// </summary>
public sealed class IntegerSequenceGenerator : SequenceGenerator<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegerSequenceGenerator"/> class.
    /// </summary>
    /// <param name="previous">The first sequence value.</param>
    /// <param name="current">The second sequence value.</param>
    public IntegerSequenceGenerator(int previous, int current)
        : base(previous, current)
    {
    }

    /// <inheritdoc/>
    protected override int GetNext() => (6 * this.Current) - (8 * this.Previous);
}

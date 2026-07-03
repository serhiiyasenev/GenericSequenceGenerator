namespace GenericSequenceGenerator;

/// <summary>
/// Generates doubles using x(n+1) = x(n) + x(n-1)/x(n).
/// </summary>
public sealed class DoubleSequenceGenerator : SequenceGenerator<double>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DoubleSequenceGenerator"/> class.
    /// </summary>
    /// <param name="previous">The first sequence value.</param>
    /// <param name="current">The second sequence value.</param>
    public DoubleSequenceGenerator(double previous, double current)
        : base(previous, current)
    {
    }

    /// <inheritdoc/>
    protected override double GetNext() => this.Current + (this.Previous / this.Current);
}

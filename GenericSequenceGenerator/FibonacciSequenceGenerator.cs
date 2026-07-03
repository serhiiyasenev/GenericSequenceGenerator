namespace GenericSequenceGenerator;

/// <summary>
/// Generates a Fibonacci-style integer sequence.
/// </summary>
public sealed class FibonacciSequenceGenerator : SequenceGenerator<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FibonacciSequenceGenerator"/> class.
    /// </summary>
    /// <param name="previous">The first sequence value.</param>
    /// <param name="current">The second sequence value.</param>
    public FibonacciSequenceGenerator(int previous, int current)
        : base(previous, current)
    {
    }

    /// <inheritdoc/>
    protected override int GetNext() => this.Previous + this.Current;
}

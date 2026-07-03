namespace GenericSequenceGenerator;

/// <summary>
/// Generates uppercase English letters by adding the zero-based positions of the two latest letters.
/// </summary>
public sealed class CharSequenceGenerator : SequenceGenerator<char>
{
    private const char FirstLetter = 'A';
    private const int AlphabetLength = 26;

    /// <summary>
    /// Initializes a new instance of the <see cref="CharSequenceGenerator"/> class.
    /// </summary>
    /// <param name="previous">The first sequence value.</param>
    /// <param name="current">The second sequence value.</param>
    public CharSequenceGenerator(char previous, char current)
        : base(previous, current)
    {
        if (previous < FirstLetter || previous > 'Z')
        {
            throw new ArgumentOutOfRangeException(nameof(previous), "Value must be an uppercase letter A-Z.");
        }

        if (current < FirstLetter || current > 'Z')
        {
            throw new ArgumentOutOfRangeException(nameof(current), "Value must be an uppercase letter A-Z.");
        }
    }

    /// <inheritdoc/>
    protected override char GetNext()
    {
        int previousPosition = this.Previous - FirstLetter;
        int currentPosition = this.Current - FirstLetter;
        int nextPosition = (previousPosition + currentPosition) % AlphabetLength;

        return (char)(FirstLetter + nextPosition);
    }
}

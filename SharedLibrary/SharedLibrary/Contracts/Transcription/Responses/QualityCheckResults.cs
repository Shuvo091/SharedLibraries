namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents the container for individual quality check results.
/// </summary>
public class QualityCheckResults
{
    /// <summary>
    /// Gets or sets the spelling check results.
    /// </summary>
    public SpellingCheckResult Spelling { get; set; } = new ();

    /// <summary>
    /// Gets or sets the grammar check results.
    /// </summary>
    public GrammarCheckResult Grammar { get; set; } = new ();

    /// <summary>
    /// Gets or sets the timestamps check results.
    /// </summary>
    public TimestampCheckResult Timestamps { get; set; } = new ();

    /// <summary>
    /// Gets or sets the dialect consistency check results.
    /// </summary>
    public DialectConsistencyCheckResult DialectConsistency { get; set; } = new ();
}

namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents a spelling issue.
/// </summary>
public class SpellingIssue
{
    /// <summary>
    /// Gets or sets the character position of the issue.
    /// </summary>
    public int Position { get; set; }

    /// <summary>
    /// Gets or sets the incorrect word or phrase.
    /// </summary>
    public string Word { get; set; } = default!;

    /// <summary>
    /// Gets or sets the suggested correction.
    /// </summary>
    public string Suggestion { get; set; } = default!;

    /// <summary>
    /// Gets or sets the confidence level for the suggestion.
    /// </summary>
    public double Confidence { get; set; }

    /// <summary>
    /// Gets or sets the severity of the issue (e.g., "minor", "major").
    /// </summary>
    public string Severity { get; set; } = default!;
}

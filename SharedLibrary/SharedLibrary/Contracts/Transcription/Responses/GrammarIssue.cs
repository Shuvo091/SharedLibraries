namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents a grammar issue.
/// </summary>
public class GrammarIssue
{
    /// <summary>
    /// Gets or sets the character position of the issue.
    /// </summary>
    public int Position { get; set; }

    /// <summary>
    /// Gets or sets the problematic phrase.
    /// </summary>
    public string Phrase { get; set; } = default!;

    /// <summary>
    /// Gets or sets the suggested correction.
    /// </summary>
    public string Suggestion { get; set; } = default!;

    /// <summary>
    /// Gets or sets the grammar rule associated with the issue.
    /// </summary>
    public string Rule { get; set; } = default!;

    /// <summary>
    /// Gets or sets the severity of the issue (e.g., "info", "warning").
    /// </summary>
    public string Severity { get; set; } = default!;
}

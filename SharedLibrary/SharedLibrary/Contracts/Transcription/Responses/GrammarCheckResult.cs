namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents a grammar check result.
/// </summary>
public class GrammarCheckResult
{
    /// <summary>
    /// Gets or sets the grammar score.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Gets or sets the list of grammar issues found.
    /// </summary>
    public List<GrammarIssue> Issues { get; set; } = new ();
}

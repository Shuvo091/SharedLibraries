namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents a spelling check result.
/// </summary>
public class SpellingCheckResult
{
    /// <summary>
    /// Gets or sets the spelling score.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Gets or sets the list of spelling issues found.
    /// </summary>
    public List<SpellingIssue> Issues { get; set; } = new ();
}

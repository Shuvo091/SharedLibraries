namespace SharedLibrary.Contracts.Transcription.Requests;

/// <summary>
/// Represents a request to perform quality checks on a transcription job.
/// </summary>
public class QualityCheckRequest
{
    /// <summary>
    /// Gets or sets the list of quality check types to perform.
    /// (e.g., "spelling", "grammar", "timestamps", "dialect_consistency").
    /// </summary>
    public List<string> CheckTypes { get; set; } = new ();

    /// <summary>
    /// Gets or sets a value indicating whether to enforce strict mode rules.
    /// </summary>
    public bool StrictMode { get; set; }

    /// <summary>
    /// Gets or sets the dialect configuration settings for the quality check.
    /// </summary>
    public DialectConfig DialectConfig { get; set; } = new ();
}

using SharedLibrary.Contracts.Transcription.Requests;

namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents a dialect consistency check result.
/// </summary>
public class DialectConsistencyCheckResult
{
    /// <summary>
    /// Gets or sets the dialect consistency score.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Gets or sets the detected dialect variant.
    /// </summary>
    public string DetectedVariant { get; set; } = default!;

    /// <summary>
    /// Gets or sets the confidence level of the detected dialect.
    /// </summary>
    public double Confidence { get; set; }

    /// <summary>
    /// Gets or sets the dialect configuration.
    /// </summary>
    public DialectConfig DialectConfig { get; set; } = new ();
}

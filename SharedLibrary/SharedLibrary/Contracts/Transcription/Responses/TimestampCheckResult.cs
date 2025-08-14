namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents a timestamp check result.
/// </summary>
public class TimestampCheckResult
{
    /// <summary>
    /// Gets or sets the timestamp score.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Gets or sets the coverage description (e.g., "7 of 7 required").
    /// </summary>
    public string Coverage { get; set; } = default!;

    /// <summary>
    /// Gets or sets the accuracy description (e.g., "±0.2s average").
    /// </summary>
    public string Accuracy { get; set; } = default!;
}

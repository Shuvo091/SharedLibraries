namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents quality-related indicators for a job.
/// </summary>
public class QualityIndicators
{
    /// <summary>
    /// Gets or sets the estimated transcription accuracy percentage.
    /// </summary>
    public double EstimatedAccuracy { get; set; }

    /// <summary>
    /// Gets or sets the confidence score percentage.
    /// </summary>
    public double ConfidenceScore { get; set; }

    /// <summary>
    /// Gets or sets the dialect consistency percentage.
    /// </summary>
    public double DialectConsistency { get; set; }

    /// <summary>
    /// Gets or sets the completeness score percentage.
    /// </summary>
    public double CompletenessScore { get; set; }
}

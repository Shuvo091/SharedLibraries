namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents the response of a quality check operation.
/// </summary>
public class QualityCheckResponse
{
    /// <summary>
    /// Gets or sets the unique identifier for the quality check.
    /// </summary>
    public string QualityCheckId { get; set; } = default!;

    /// <summary>
    /// Gets or sets the overall score for the quality check.
    /// </summary>
    public double OverallScore { get; set; }

    /// <summary>
    /// Gets or sets the detailed results of each quality check type.
    /// </summary>
    public QualityCheckResults CheckResults { get; set; } = new ();

    /// <summary>
    /// Gets or sets the list of general suggestions from the quality check.
    /// </summary>
    public List<string> Suggestions { get; set; } = new ();
}

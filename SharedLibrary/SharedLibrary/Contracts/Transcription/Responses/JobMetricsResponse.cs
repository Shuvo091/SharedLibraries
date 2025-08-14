namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents the response model containing job metrics, playback metrics, and quality indicators.
/// </summary>
public class JobMetricsResponse
{
    /// <summary>
    /// Gets or sets the unique identifier of the job.
    /// </summary>
    public Guid JobId { get; set; }

    /// <summary>
    /// Gets or sets the performance metrics for the job.
    /// </summary>
    public PerformanceMetrics PerformanceMetrics { get; set; } = new ();

    /// <summary>
    /// Gets or sets the playback metrics for the job.
    /// </summary>
    public PlaybackMetrics PlaybackMetrics { get; set; } = new ();

    /// <summary>
    /// Gets or sets the quality indicators for the job.
    /// </summary>
    public QualityIndicators QualityIndicators { get; set; } = new ();
}

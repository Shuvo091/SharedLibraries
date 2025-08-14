namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents playback-related metrics for a job.
/// </summary>
public class PlaybackMetrics
{
    /// <summary>
    /// Gets or sets the total playback time (e.g., "2m34s").
    /// </summary>
    public string TotalPlaybackTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets the average playback speed.
    /// </summary>
    public double AveragePlaybackSpeed { get; set; }

    /// <summary>
    /// Gets or sets the speed distribution of playback speeds used.
    /// </summary>
    public Dictionary<string, string> SpeedDistribution { get; set; } = new ();

    /// <summary>
    /// Gets or sets the total number of rewinds performed.
    /// </summary>
    public int RewindCount { get; set; }

    /// <summary>
    /// Gets or sets the number of timestamp insertions made.
    /// </summary>
    public int TimestampInsertions { get; set; }
}

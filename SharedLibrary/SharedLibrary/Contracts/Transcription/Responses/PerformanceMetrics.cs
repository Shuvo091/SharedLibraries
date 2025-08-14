namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents performance-related metrics for a job.
/// </summary>
public class PerformanceMetrics
{
    /// <summary>
    /// Gets or sets the total time spent on the job (e.g., "23m45s").
    /// </summary>
    public string TotalTimeSpent { get; set; } = default!;

    /// <summary>
    /// Gets or sets the active typing time (e.g., "18m12s").
    /// </summary>
    public string ActiveTypingTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets the total pause time (e.g., "5m33s").
    /// </summary>
    public string PauseTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets the words per minute achieved during the job.
    /// </summary>
    public int WordsPerMinute { get; set; }

    /// <summary>
    /// Gets or sets the keystrokes per minute achieved during the job.
    /// </summary>
    public int KeystrokesPerMinute { get; set; }

    /// <summary>
    /// Gets or sets the ratio of backspaces to total keystrokes.
    /// </summary>
    public double BackspaceRatio { get; set; }

    /// <summary>
    /// Gets or sets the number of spelling corrections made during the job.
    /// </summary>
    public int SpellingCorrections { get; set; }
}

namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Response object for additional transcriber request.
/// </summary>
public class RequestAdditionalTranscriberResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether additonal transcriber was requested.
    /// </summary>
    public bool AdditionalTranscriberRequested { get; set; }

    /// <summary>
    /// Gets or sets a value indicating new job status.
    /// Gets kept as string because incoming values use snake_case (e.g. "seeking_additional_transcriber").
    /// </summary>
    public string JobStatus { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets value indicating estimated time match.
    /// Free-form estimated match time (e.g. "30m"). You can parse it to TimeSpan if you standardize format.
    /// </summary>
    public string EstimatedMatchTime { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets value indicating extended dealine.
    /// </summary>
    public DateTime ExtendedDeadline { get; set; }
}

namespace SharedLibrary.Contracts.Transcription.Requests;

/// <summary>
/// Request object for additional transcriber request.
/// </summary>
public class RequestAdditionalTranscriberRequest
{
    /// <summary>
    /// Gets or sets a value indicating the reason for request.
    /// </summary>
    public string Reason { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating the urgency of request.
    /// </summary>
    public string Urgency { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating the entended timeline.
    /// </summary>
    public int DeadlineExtensionInMinutes { get; set; }
}

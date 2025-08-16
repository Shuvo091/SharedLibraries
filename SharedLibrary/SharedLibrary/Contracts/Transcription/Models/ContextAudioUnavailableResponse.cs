namespace SharedLibrary.Contracts.Transcription.Models;

/// <summary>
/// Response model when context audio is unavailable.
/// </summary>
public class ContextAudioUnavailableResponse
{
    /// <summary>
    /// Gets or sets error code representing the failure.
    /// </summary>
    public string Error { get; set; } = "context_unavailable";

    /// <summary>
    /// Gets or sets human-readable message explaining the error.
    /// </summary>
    public string Message { get; set; } = default!;

    /// <summary>
    /// Gets or sets flags indicating which context directions are available.
    /// </summary>
    public AvailableContext AvailableContext { get; set; } = new ();

    /// <summary>
    /// Gets or sets uRI for the fallback single chunk audio.
    /// </summary>
    public string FallbackUri { get; set; } = default!;

    /// <summary>
    /// Gets or sets recommendation for how to proceed.
    /// </summary>
    public string Recommendation { get; set; } = default!;
}

/// <summary>
/// Indicates whether adjacent context segments are available.
/// </summary>
public class AvailableContext
{
    /// <summary>
    /// Gets or sets a value indicating whether gets or sets Previous.
    /// </summary>
    public bool Previous { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether gets or sets Next.
    /// </summary>
    public bool Next { get; set; }
}
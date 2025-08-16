using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Combined result for audio context.
/// </summary>
public class ContextAudioResult
{
    /// <summary>
    /// Gets or sets success.
    /// </summary>
    public ContextAudioResponse? Success { get; set; }

    /// <summary>
    /// Gets or sets not found.
    /// </summary>
    public ContextAudioUnavailableResponse? NotFound { get; set; }
}

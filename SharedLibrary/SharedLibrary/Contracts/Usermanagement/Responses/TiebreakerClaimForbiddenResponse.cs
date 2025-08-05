namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response when a tiebreaker claim is forbidden.
/// </summary>
public class TiebreakerClaimForbiddenResponse
{
    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    public string Error { get; set; } = "original_transcriber_not_eligible";

    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    public string Message { get; set; } = "Users who participated in the original transcription cannot be tiebreakers";

    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    public string UserId { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the user was an original transcriber.
    /// </summary>
    public bool WasOriginalTranscriber { get; set; }
}
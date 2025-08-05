namespace SharedLibrary.Contracts.QA.Requests;

/// <summary>
/// Represents a request to resolve a tiebreaker in comparison.
/// </summary>
public class TiebreakerRequest
{
    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    required public string WorkflowRequestId { get; set; }

    /// <summary>
    /// Gets or sets tiebreaker transcription.
    /// </summary>
    required public SharedLibrary.Contracts.QA.Models.Transcription TiebreakerTranscription { get; set; }
}

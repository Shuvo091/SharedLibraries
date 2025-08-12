namespace SharedLibrary.Contracts.Transcription.Responses;

/// <summary>
/// Represents the response returned when a tiebreaker has been requested for a job.
/// </summary>
public class RequestTiebreakerResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether a tiebreaker is requested.
    /// </summary>
    public bool? TiebreakerRequested { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the tiebreaker.
    /// </summary>
    public Guid TiebreakerId { get; set; }

    /// <summary>
    /// Gets or sets the current status of the job.
    /// </summary>
    public string? JobStatus { get; set; }

    /// <summary>
    /// Gets or sets the estimated time required for the tiebreaker (e.g., "2h").
    /// </summary>
    public string? EstimatedTiebreakerTime { get; set; }

    /// <summary>
    /// Gets or sets the priority level of the tiebreaker request (e.g., "high", "medium", "low").
    /// </summary>
    public string? PriorityLevel { get; set; }
}

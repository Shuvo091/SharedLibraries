namespace SharedLibrary.Contracts.Transcription.Requests;

/// <summary>
/// Represents a request to setiate a tiebreaker process for a comparison.
/// </summary>
public class RequestTiebreakerRequest
{
    /// <summary>
    /// Gets or sets The unique identifier of the comparison.
    /// </summary>
    public string ComparisonId { get; set; } = default!;

    /// <summary>
    /// Gets or sets The reason for triggering the tiebreaker process.
    /// </summary>
    public string Reason { get; set; } = default!;

    /// <summary>
    /// Gets or sets The OpenAI-generated assessment details for the comparison.
    /// </summary>
    public OpenAiAssessment OpenAiAssessment { get; set; } = new ();

    /// <summary>
    /// Gets or sets The urgency level of the tiebreaker (e.g., high, medium, low).
    /// </summary>
    public string Urgency { get; set; } = default!;

    /// <summary>
    /// Gets or sets The deadline by which the tiebreaker must be completed.
    /// </summary>
    public DateTime TiebreakerDeadline { get; set; }

    /// <summary>
    /// Gets or sets Requirements and restrictions for selecting a tiebreaker.
    /// </summary>
    public TiebreakerRequirements TiebreakerRequirements { get; set; } = new ();
}

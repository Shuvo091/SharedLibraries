using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Detail response for a comparison.
/// </summary>
public class ComparisonDetailResponse
{
    /// <summary>
    /// Gets or sets the unique identifier for the comparison.
    /// </summary>
    required public Guid ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets assessment result from OpenAI.
    /// </summary>
    public OpenAiResult? OpenAiAssessment { get; set; }

    /// <summary>
    /// Gets or sets the list of participants involved in the comparison.
    /// </summary>
    required public List<Participant> Participants { get; set; }

    /// <summary>
    /// Gets or sets the completion date and time of the comparison.
    /// </summary>
    public DateTime? CompletedAt { get; set; }
}

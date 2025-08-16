using SharedLibrary.Contracts.Usermanagement.Models;

namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response after applying Elo updates.
/// </summary>
public class EloUpdateResponse
{
    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    public string? WorkflowRequestId { get; set; }

    /// <summary>
    /// Gets or sets list of applied Elo updates.
    /// </summary>
    public List<EloUpdateAppliedDto> EloUpdatesApplied { get; set; } = [];

    /// <summary>
    /// Gets or sets unique identifier for the comparison.
    /// </summary>
    public Guid ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets timestamp when the update was applied.
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}

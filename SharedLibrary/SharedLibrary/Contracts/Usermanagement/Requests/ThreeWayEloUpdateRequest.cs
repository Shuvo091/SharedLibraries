using System.ComponentModel.DataAnnotations;
using SharedLibrary.Contracts.Usermanagement.Models;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Request to update Elo ratings for a three-way comparison scenario.
/// </summary>
public class ThreeWayEloUpdateRequest
{
    /// <summary>
    /// Gets or sets original comparison identifier.
    /// </summary>
    [Required(ErrorMessage = "OriginalComparisonId is required.")]
    public Guid OriginalComparisonId { get; set; }

    /// <summary>
    /// Gets or sets tiebreaker comparison identifier.
    /// </summary>
    [Required(ErrorMessage = "TiebreakerComparisonId is required.")]
    public Guid TiebreakerComparisonId { get; set; }

    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    [Required(ErrorMessage = "WorkflowRequestId is required.")]
    [MinLength(1, ErrorMessage = "WorkflowRequestId cannot be empty.")]
    public string WorkflowRequestId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets list of Elo changes for the three-way comparison.
    /// </summary>
    [Required(ErrorMessage = "ThreeWayEloChanges is required.")]
    [MinLength(1, ErrorMessage = "At least one ThreeWayEloChange entry is required.")]
    public List<ThreeWayEloChange> ThreeWayEloChanges { get; set; } = new ();
}

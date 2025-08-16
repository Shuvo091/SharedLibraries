using System.ComponentModel.DataAnnotations;
using SharedLibrary.Contracts.Usermanagement.Models;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Request to update Elo ratings after a QA comparison.
/// </summary>
public class EloUpdateRequest
{
    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    [Required(ErrorMessage = "WorkflowRequestId is required.")]
    public string WorkflowRequestId { get; set; } = default!;

    /// <summary>
    /// Gets or sets unique identifier for the QA comparison.
    /// </summary>
    [Required(ErrorMessage = "QaComparisonId is required.")]
    public Guid QaComparisonId { get; set; }

    /// <summary>
    /// Gets or sets reference to the QA service.
    /// </summary>
    [Required(ErrorMessage = "QaServiceReference is required.")]
    public string QaServiceReference { get; set; } = default!;

    /// <summary>
    /// Gets or sets list of recommended Elo changes for transcribers.
    /// </summary>
    [MinLength(1, ErrorMessage = "At least one Elo change is required.")]
    public List<RecommendedEloChangeDto> RecommendedEloChanges { get; set; } = new ();

    /// <summary>
    /// Gets or sets metadata about the comparison.
    /// </summary>
    [Required(ErrorMessage = "ComparisonMetadata is required.")]
    public ComparisonMetadataDto ComparisonMetadata { get; set; } = new ();
}

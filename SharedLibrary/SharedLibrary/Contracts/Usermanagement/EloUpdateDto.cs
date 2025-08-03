using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Data transfer object representing a recommended Elo change for a transcriber.
/// </summary>
public class RecommendedEloChangeDto
{
    /// <summary>
    /// Gets or sets unique identifier for the transcriber.
    /// </summary>
    [Required(ErrorMessage = "TranscriberId is required.")]
    public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo before the change.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "OldElo must be 0 or greater.")]
    public int OldElo { get; set; }

    /// <summary>
    /// Gets or sets recommended Elo change value.
    /// </summary>
    [Range(-1000, 1000, ErrorMessage = "RecommendedChange must be between -1000 and 1000.")]
    public int RecommendedChange { get; set; }

    /// <summary>
    /// Gets or sets outcome of the comparison for the transcriber.
    /// </summary>
    [Required(ErrorMessage = "ComparisonOutcome is required.")]
    public string? ComparisonOutcome { get; set; }

    /// <summary>
    /// Gets or sets elo rating of the opponent.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "OpponentElo must be 0 or greater.")]
    public int OpponentElo { get; set; }
}

/// <summary>
/// Metadata about a QA comparison.
/// </summary>
public class ComparisonMetadataDto
{
    /// <summary>
    /// Gets or sets audio segment identifier.
    /// </summary>
    [Required(ErrorMessage = "AudioSegmentId is required.")]
    public string? AudioSegmentId { get; set; }

    /// <summary>
    /// Gets or sets type of comparison performed.
    /// </summary>
    [Required(ErrorMessage = "ComparisonType is required.")]
    public string? ComparisonType { get; set; }

    /// <summary>
    /// Gets or sets confidence score from QA (0 to 1).
    /// </summary>
    [Range(0, 1, ErrorMessage = "QaConfidence must be between 0 and 1.")]
    public double QaConfidence { get; set; }

    /// <summary>
    /// Gets or sets qA method used.
    /// </summary>
    [Required(ErrorMessage = "QaMethod is required.")]
    public string? QaMethod { get; set; }

    /// <summary>
    /// Gets or sets timestamp of the comparison.
    /// </summary>
    [Required(ErrorMessage = "ComparisonTimestamp is required.")]
    public DateTime ComparisonTimestamp { get; set; }
}

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

/// <summary>
/// Data transfer object representing an applied Elo update.
/// </summary>
public class EloUpdateAppliedDto
{
    /// <summary>
    /// Gets or sets unique identifier for the transcriber.
    /// </summary>
    public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo before the update.
    /// </summary>
    public int OldElo { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo after the update.
    /// </summary>
    public int NewElo { get; set; }

    /// <summary>
    /// Gets or sets amount of Elo change applied.
    /// </summary>
    public int EloChange { get; set; }

    /// <summary>
    /// Gets or sets outcome of the comparison for the transcriber.
    /// </summary>
    public string? ComparisonOutcome { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Elo Update Request
public class EloUpdateRequest
{
	[Required(ErrorMessage = "WorkflowRequestId is required.")]
	public string WorkflowRequestId { get; set; } = default!;

	[Required(ErrorMessage = "QaComparisonId is required.")]
	public Guid QaComparisonId { get; set; }

	[Required(ErrorMessage = "QaServiceReference is required.")]
	public string QaServiceReference { get; set; } = default!;

	[MinLength(1, ErrorMessage = "At least one Elo change is required.")]
	public List<RecommendedEloChangeDto> RecommendedEloChanges { get; set; } = new();

	[Required(ErrorMessage = "ComparisonMetadata is required.")]
	public ComparisonMetadataDto ComparisonMetadata { get; set; } = new();
}

public class RecommendedEloChangeDto
{
	[Required(ErrorMessage = "TranscriberId is required.")]
	public Guid TranscriberId { get; set; }

	[Range(0, int.MaxValue, ErrorMessage = "OldElo must be 0 or greater.")]
	public int OldElo { get; set; }

	[Range(-1000, 1000, ErrorMessage = "RecommendedChange must be between -1000 and 1000.")]
	public int RecommendedChange { get; set; }

	[Required(ErrorMessage = "ComparisonOutcome is required.")]
	public string? ComparisonOutcome { get; set; }

	[Range(0, int.MaxValue, ErrorMessage = "OpponentElo must be 0 or greater.")]
	public int OpponentElo { get; set; }
}

public class ComparisonMetadataDto
{
	[Required(ErrorMessage = "AudioSegmentId is required.")]
	public string? AudioSegmentId { get; set; }

	[Required(ErrorMessage = "ComparisonType is required.")]
	public string? ComparisonType { get; set; }

	[Range(0, 1, ErrorMessage = "QaConfidence must be between 0 and 1.")]
	public double QaConfidence { get; set; }

	[Required(ErrorMessage = "QaMethod is required.")]
	public string? QaMethod { get; set; }

	[Required(ErrorMessage = "ComparisonTimestamp is required.")]
	public DateTime ComparisonTimestamp { get; set; }
}

#endregion

#region ELO Update Response

public class EloUpdateResponse
{
    public string? WorkflowRequestId { get; set; }
    public List<EloUpdateAppliedDto> EloUpdatesApplied { get; set; } = [];
    public Guid ComparisonId { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class EloUpdateAppliedDto
{
    public Guid TranscriberId { get; set; }
    public int OldElo { get; set; }
    public int NewElo { get; set; }
    public int EloChange { get; set; }
    public string? ComparisonOutcome { get; set; }
}

#endregion
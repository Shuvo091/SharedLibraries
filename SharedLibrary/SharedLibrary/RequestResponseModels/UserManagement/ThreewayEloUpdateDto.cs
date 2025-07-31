using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Three-Way Elo Update Request

public class ThreeWayEloUpdateRequest
{
	[Required(ErrorMessage = "OriginalComparisonId is required.")]
	public Guid OriginalComparisonId { get; set; }

	[Required(ErrorMessage = "TiebreakerComparisonId is required.")]
	public Guid TiebreakerComparisonId { get; set; }

	[Required(ErrorMessage = "WorkflowRequestId is required.")]
	[MinLength(1, ErrorMessage = "WorkflowRequestId cannot be empty.")]
	public string WorkflowRequestId { get; set; } = string.Empty;

	[Required(ErrorMessage = "ThreeWayEloChanges is required.")]
	[MinLength(1, ErrorMessage = "At least one ThreeWayEloChange entry is required.")]
	public List<ThreeWayEloChange> ThreeWayEloChanges { get; set; } = new();
}

public class ThreeWayEloChange
{
	[Required(ErrorMessage = "TranscriberId is required.")]
	public Guid TranscriberId { get; set; }

	[Required(ErrorMessage = "Role is required.")]
	[MinLength(1, ErrorMessage = "Role cannot be empty.")]
	public string Role { get; set; } = string.Empty;

	[Required(ErrorMessage = "Outcome is required.")]
	[MinLength(1, ErrorMessage = "Outcome cannot be empty.")]
	public string Outcome { get; set; } = string.Empty;

	public int EloChange { get; set; }

	public int NewElo { get; set; }

	public TiebreakerBonus? TiebreakerBonus { get; set; }
}

public class TiebreakerBonus
{
	public bool Applied { get; set; }

	public int BonusAmount { get; set; }

	[Required(ErrorMessage = "Reason is required.")]
	[MinLength(1, ErrorMessage = "Reason cannot be empty.")]
	public string Reason { get; set; } = string.Empty;
}

#endregion

#region Three-Way Elo Update Response

public class ThreeWayEloUpdateResponse
{
    public bool EloUpdateConfirmed { get; set; }
    public int UpdatesApplied { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public List<UserNotification> UserNotifications { get; set; } = [];
}

public class UserNotification
{
    public Guid UserId { get; set; }
    public string NotificationType { get; set; } = default!;
    public string Message { get; set; } = default!;
}

#endregion
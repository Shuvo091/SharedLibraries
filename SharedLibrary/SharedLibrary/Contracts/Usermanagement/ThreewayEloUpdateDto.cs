using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Data transfer object representing an Elo change in a three-way comparison.
/// </summary>
public class ThreeWayEloChange
{
    /// <summary>
    /// Gets or sets unique identifier for the transcriber.
    /// </summary>
    [Required(ErrorMessage = "TranscriberId is required.")]
    public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets role of the transcriber in the comparison.
    /// </summary>
    [Required(ErrorMessage = "Role is required.")]
    [MinLength(1, ErrorMessage = "Role cannot be empty.")]
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets outcome for the transcriber in the comparison.
    /// </summary>
    [Required(ErrorMessage = "Outcome is required.")]
    [MinLength(1, ErrorMessage = "Outcome cannot be empty.")]
    public string Outcome { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets amount of Elo change applied.
    /// </summary>
    public int EloChange { get; set; }

    /// <summary>
    /// Gets or sets new Elo rating after the change.
    /// </summary>
    public int NewElo { get; set; }

    /// <summary>
    /// Gets or sets tiebreaker bonus details, if applicable.
    /// </summary>
    public TiebreakerBonus? TiebreakerBonus { get; set; }
}

/// <summary>
/// Details about a tiebreaker bonus in a three-way comparison.
/// </summary>
public class TiebreakerBonus
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the bonus was applied.
    /// </summary>
    public bool Applied { get; set; }

    /// <summary>
    /// Gets or sets amount of the bonus applied.
    /// </summary>
    public int BonusAmount { get; set; }

    /// <summary>
    /// Gets or sets reason for the bonus.
    /// </summary>
    [Required(ErrorMessage = "Reason is required.")]
    [MinLength(1, ErrorMessage = "Reason cannot be empty.")]
    public string Reason { get; set; } = string.Empty;
}

/// <summary>
/// Response after updating Elo ratings for a three-way comparison.
/// </summary>
public class ThreeWayEloUpdateResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the Elo update was confirmed.
    /// </summary>
    public bool EloUpdateConfirmed { get; set; }

    /// <summary>
    /// Gets or sets number of updates applied.
    /// </summary>
    public int UpdatesApplied { get; set; }

    /// <summary>
    /// Gets or sets timestamp when the update was made.
    /// </summary>
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets list of notifications for users affected by the update.
    /// </summary>
    public List<UserNotification> UserNotifications { get; set; } = [];
}

/// <summary>
/// Notification details for a user affected by an Elo update.
/// </summary>
public class UserNotification
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets type of notification.
    /// </summary>
    public string NotificationType { get; set; } = default!;

    /// <summary>
    /// Gets or sets notification message.
    /// </summary>
    public string Message { get; set; } = default!;
}
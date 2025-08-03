using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Response containing a list of available users and related metadata.
/// </summary>
public class UserAvailabilityResponse
{
    /// <summary>
    /// Gets or sets list of users currently available.
    /// </summary>
    public List<AvailableUsersDto> AvailableUsers { get; set; } = [];

    /// <summary>
    /// Gets or sets total number of available users.
    /// </summary>
    public int TotalAvailable { get; set; }

    /// <summary>
    /// Gets or sets timestamp when the query was made.
    /// </summary>
    public DateTime QueryTimestamp { get; set; }
}

/// <summary>
/// Data transfer object representing an available user.
/// </summary>
public class AvailableUsersDto
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int? EloRating { get; set; }

    /// <summary>
    /// Gets or sets user's peak Elo rating.
    /// </summary>
    public int? PeakElo { get; set; }

    /// <summary>
    /// Gets or sets list of dialects the user is expert in.
    /// </summary>
    public List<string>? DialectExpertise { get; set; } = [];

    /// <summary>
    /// Gets or sets user's current workload.
    /// </summary>
    public int? CurrentWorkload { get; set; }

    /// <summary>
    /// Gets or sets recent performance summary for the user.
    /// </summary>
    public string? RecentPerformance { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets number of games played by the user.
    /// </summary>
    public int? GamesPlayed { get; set; }

    /// <summary>
    /// Gets or sets user's role.
    /// </summary>
    public string? Role { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets indicates if QA comparison is bypassed for the user.
    /// </summary>
    public bool? BypassQaComparison { get; set; }

    /// <summary>
    /// Gets or sets last time the user was active.
    /// </summary>
    public DateTime? LastActive { get; set; }
}

/// <summary>
/// Request to update a user's availability status.
/// </summary>
public class UserAvailabilityUpdateRequest
{
    /// <summary>
    /// Gets or sets new status for the user (available, busy, offline, leave).
    /// </summary>
    [Required]
    [RegularExpression("available|busy|offline|leave", ErrorMessage = "Status must be 'available', 'busy', 'offline', or 'leave'.")]
    public string Status { get; set; } = default!;

    /// <summary>
    /// Gets or sets maximum number of concurrent jobs the user can handle.
    /// </summary>
    [Range(1, 10, ErrorMessage = "MaxConcurrentJobs must be between 1 and 10.")]
    public int MaxConcurrentJobs { get; set; } = 3;

    /// <summary>
    /// Gets or sets optional notes about the user's availability.
    /// </summary>
    [MaxLength(500, ErrorMessage = "Notes can't exceed 500 characters.")]
    public string? Notes { get; set; }
}

/// <summary>
/// Response after updating a user's availability.
/// </summary>
public class UserAvailabilityUpdateResponse
{
    /// <summary>
    /// Gets or sets confirmation message for the update.
    /// </summary>
    public string AvailabilityUpdated { get; set; } = default!;

    /// <summary>
    /// Gets or sets the user's current status after the update.
    /// </summary>
    public string CurrentStatus { get; set; } = default!;

    /// <summary>
    /// Gets or sets the user's maximum concurrent jobs after the update.
    /// </summary>
    public int MaxConcurrentJobs { get; set; } = 3;

    /// <summary>
    /// Gets or sets the timestamp when the update was made.
    /// </summary>
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
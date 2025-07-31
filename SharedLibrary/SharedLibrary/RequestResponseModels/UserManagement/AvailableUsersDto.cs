using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region All User Availability Response 

public class UserAvailabilityResponse
{
    public List<AvailableUsersDto> AvailableUsers { get; set; } = [];
    public int TotalAvailable { get; set; }
    public DateTime QueryTimestamp { get; set; }
}

public class AvailableUsersDto
{
    public Guid UserId { get; set; }
    public int? EloRating { get; set; }
    public int? PeakElo { get; set; }
    public List<string>? DialectExpertise { get; set; } = [];
    public int? CurrentWorkload { get; set; }
    public string? RecentPerformance { get; set; } = "";
    public int? GamesPlayed { get; set; }
    public string? Role { get; set; } = "";
    public bool? BypassQaComparison { get; set; }
    public DateTime? LastActive { get; set; }
}

#endregion

#region User Availability Request

public class UserAvailabilityUpdateRequest
{
	[Required]
	[RegularExpression("available|busy|offline|leave", ErrorMessage = "Status must be 'available', 'busy', 'offline', or 'leave'.")]
	public string Status { get; set; } = default!;

	[Range(1, 10, ErrorMessage = "MaxConcurrentJobs must be between 1 and 10.")]
	public int MaxConcurrentJobs { get; set; } = 3;

	[MaxLength(500, ErrorMessage = "Notes can't exceed 500 characters.")]
	public string? Notes { get; set; }
}

#endregion

#region User Availability Update Response

public class UserAvailabilityUpdateResponse
{
    public string AvailabilityUpdated { get; set; } = default!;
    public string CurrentStatus { get; set; } = default!;
    public int MaxConcurrentJobs { get; set; } = 3;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}

#endregion
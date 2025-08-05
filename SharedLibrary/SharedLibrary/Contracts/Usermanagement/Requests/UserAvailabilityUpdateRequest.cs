using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

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
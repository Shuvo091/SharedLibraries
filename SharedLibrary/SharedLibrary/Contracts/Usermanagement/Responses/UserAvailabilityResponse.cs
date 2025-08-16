using SharedLibrary.Contracts.Usermanagement.Models;

namespace SharedLibrary.Contracts.Usermanagement.Responses;

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

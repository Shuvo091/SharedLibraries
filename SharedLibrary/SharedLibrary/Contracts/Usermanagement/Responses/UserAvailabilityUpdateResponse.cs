namespace SharedLibrary.Contracts.Usermanagement.Responses;

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
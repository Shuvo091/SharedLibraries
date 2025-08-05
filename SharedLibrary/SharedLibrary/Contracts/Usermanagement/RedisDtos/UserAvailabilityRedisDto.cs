namespace SharedLibrary.Contracts.Usermanagement.RedisDtos;

/// <summary>
/// Data transfer object for storing user availability in Redis.
/// </summary>
public class UserAvailabilityRedisDto
{
    /// <summary>
    /// Gets or sets user's current status (e.g., available, busy).
    /// </summary>
    public string Status { get; set; } = default!;

    /// <summary>
    /// Gets or sets maximum number of concurrent jobs allowed for the user.
    /// </summary>
    public int MaxConcurrentJobs { get; set; } = 3;

    /// <summary>
    /// Gets or sets user's current workload.
    /// </summary>
    public int CurrentWorkload { get; set; } = 0;

    /// <summary>
    /// Gets or sets timestamp of the last update.
    /// </summary>
    public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
}
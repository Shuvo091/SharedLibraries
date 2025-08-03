namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Data transfer object for storing user Elo information in Redis.
/// </summary>
public class UserEloRedisDto
{
    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int CurrentElo { get; set; }

    /// <summary>
    /// Gets or sets user's peak Elo rating.
    /// </summary>
    public int PeakElo { get; set; }

    /// <summary>
    /// Gets or sets number of games played by the user.
    /// </summary>
    public int GamesPlayed { get; set; }

    /// <summary>
    /// Gets or sets recent trend in Elo rating.
    /// </summary>
    public string RecentTrend { get; set; } = default!;

    /// <summary>
    /// Gets or sets timestamp of the last job completed by the user.
    /// </summary>
    public DateTime LastJobCompleted { get; set; }
}
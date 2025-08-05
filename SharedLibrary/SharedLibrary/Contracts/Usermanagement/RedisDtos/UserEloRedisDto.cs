namespace SharedLibrary.Contracts.Usermanagement.RedisDtos;

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
namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// User statistics data transfer object.
/// </summary>
public class UserStatisticsDto
{
    /// <summary>
    /// Gets or sets total number of jobs completed by the user.
    /// </summary>
    public int TotalJobsCompleted { get; set; }

    /// <summary>
    /// Gets or sets number of games played by the user.
    /// </summary>
    public int GamesPlayed { get; set; }

    /// <summary>
    /// Gets or sets trend in Elo rating.
    /// </summary>
    public string EloTrend { get; set; } = default!;

    /// <summary>
    /// Gets or sets list of dialects the user is expert in.
    /// </summary>
    public List<string> DialectExpertise { get; set; } = [];

    /// <summary>
    /// Gets or sets user's win rate.
    /// </summary>
    public double WinRate { get; set; }

    /// <summary>
    /// Gets or sets statistics for the last 30 days.
    /// </summary>
    public Last30DaysStatsDto Last30Days { get; set; } = new ();
}

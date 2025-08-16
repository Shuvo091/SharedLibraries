namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Data transfer object representing Elo trends for a user.
/// </summary>
public class EloTrendsDto
{
    /// <summary>
    /// Gets or sets elo change in the last 7 days.
    /// </summary>
    public string Last7Days { get; set; } = "0";

    /// <summary>
    /// Gets or sets elo change in the last 30 days.
    /// </summary>
    public string Last30Days { get; set; } = "0";

    /// <summary>
    /// Gets or sets user's win rate (e.g., 0.67).
    /// </summary>
    public double WinRate { get; set; } // 0.67

    /// <summary>
    /// Gets or sets average Elo rating of opponents.
    /// </summary>
    public double AverageOpponentElo { get; set; }
}
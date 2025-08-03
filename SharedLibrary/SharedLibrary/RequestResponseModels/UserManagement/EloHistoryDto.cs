namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Response containing Elo history and trends for a user.
/// </summary>
public class EloHistoryResponse
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int CurrentElo { get; set; }

    /// <summary>
    /// Gets or sets user's peak Elo rating.
    /// </summary>
    public int PeakElo { get; set; }

    /// <summary>
    /// Gets or sets user's initial Elo rating.
    /// </summary>
    public int InitialElo { get; set; }

    /// <summary>
    /// Gets or sets number of games played by the user.
    /// </summary>
    public int GamesPlayed { get; set; }

    /// <summary>
    /// Gets or sets list of Elo history entries.
    /// </summary>
    public List<EloEntryDto> EloHistory { get; set; } = [];

    /// <summary>
    /// Gets or sets trends in the user's Elo performance.
    /// </summary>
    public EloTrendsDto Trends { get; set; } = new ();
}

/// <summary>
/// Data transfer object representing a single Elo history entry.
/// </summary>
public class EloEntryDto
{
    /// <summary>
    /// Gets or sets date of the Elo change.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets elo rating before the change.
    /// </summary>
    public int OldElo { get; set; }

    /// <summary>
    /// Gets or sets elo rating after the change.
    /// </summary>
    public int NewElo { get; set; }

    /// <summary>
    /// Gets string representation of the Elo change (e.g., +10, -5).
    /// </summary>
    public string Change => this.NewElo >= this.OldElo ? $"+{this.NewElo - this.OldElo}" : $"-{this.OldElo - this.NewElo}";

    /// <summary>
    /// Gets or sets unique identifier for the opponent.
    /// </summary>
    public Guid Opponent { get; set; }

    /// <summary>
    /// Gets or sets outcome of the match (e.g., win, loss).
    /// </summary>
    public string Outcome { get; set; } = string.Empty; // "win", "loss", etc.

    /// <summary>
    /// Gets or sets job identifier associated with the Elo change.
    /// </summary>
    public string JobId { get; set; } = default!;
}

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
namespace SharedLibrary.Contracts.Usermanagement.Responses;

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

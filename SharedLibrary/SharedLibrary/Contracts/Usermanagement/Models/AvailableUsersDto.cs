namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Data transfer object representing an available user.
/// </summary>
public class AvailableUsersDto
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int? EloRating { get; set; }

    /// <summary>
    /// Gets or sets user's peak Elo rating.
    /// </summary>
    public int? PeakElo { get; set; }

    /// <summary>
    /// Gets or sets list of dialects the user is expert in.
    /// </summary>
    public List<string>? DialectExpertise { get; set; } = [];

    /// <summary>
    /// Gets or sets user's current workload.
    /// </summary>
    public int? CurrentWorkload { get; set; }

    /// <summary>
    /// Gets or sets recent performance summary for the user.
    /// </summary>
    public string? RecentPerformance { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets number of games played by the user.
    /// </summary>
    public int? GamesPlayed { get; set; }

    /// <summary>
    /// Gets or sets user's role.
    /// </summary>
    public string? Role { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets indicates if QA comparison is bypassed for the user.
    /// </summary>
    public bool? BypassQaComparison { get; set; }

    /// <summary>
    /// Gets or sets last time the user was active.
    /// </summary>
    public DateTime? LastActive { get; set; }
}
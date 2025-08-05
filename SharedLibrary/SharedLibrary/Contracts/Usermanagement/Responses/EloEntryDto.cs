namespace SharedLibrary.Contracts.Usermanagement.Responses;

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

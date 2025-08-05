namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Result of an Elo update for a user.
/// </summary>
public class EloUpdateResult
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user's new Elo rating after the update.
    /// </summary>
    public int NewElo { get; set; }

    /// <summary>
    /// Gets or sets amount of Elo change applied.
    /// </summary>
    public int Change { get; set; }
}

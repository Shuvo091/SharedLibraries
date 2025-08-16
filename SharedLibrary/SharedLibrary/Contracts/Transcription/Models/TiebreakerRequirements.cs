namespace SharedLibrary.Contracts.Transcription.Models;

/// <summary>
/// Defines the rules and constraints for selecting a tiebreaker.
/// </summary>
public record TiebreakerRequirements
{
    /// <summary>
    /// Gets or sets The minimum Elo rating required for a user to be eligible as a tiebreaker.
    /// </summary>
    public int MinEloRequired { get; set; }

    /// <summary>
    /// Gets or sets A list of user IDs that must be excluded from selection as a tiebreaker.
    /// </summary>
    public List<string> ExcludeUserIds { get; set; } = new ();

    /// <summary>
    /// Gets or sets A multiplier applied to the reward for the tiebreaker.
    /// </summary>
    public double BonusMultiplier { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the tiebreaker should receive a priority notification.
    /// </summary>
    public bool PriorityNotification { get; set; }
}

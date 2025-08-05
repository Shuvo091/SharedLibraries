namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response after updating Elo ratings for a three-way comparison.
/// </summary>
public class ThreeWayEloUpdateResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the Elo update was confirmed.
    /// </summary>
    public bool EloUpdateConfirmed { get; set; }

    /// <summary>
    /// Gets or sets number of updates applied.
    /// </summary>
    public int UpdatesApplied { get; set; }

    /// <summary>
    /// Gets or sets timestamp when the update was made.
    /// </summary>
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets list of notifications for users affected by the update.
    /// </summary>
    public List<UserNotification> UserNotifications { get; set; } = [];
}

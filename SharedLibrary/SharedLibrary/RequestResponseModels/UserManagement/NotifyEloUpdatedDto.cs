namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Request to notify about an Elo update event.
/// </summary>
public class EloUpdateNotificationRequest
{
    /// <summary>
    /// Gets or sets type of the event.
    /// </summary>
    public string EventType { get; set; } = default!;

    /// <summary>
    /// Gets or sets unique identifier for the update event.
    /// </summary>
    public string UpdateId { get; set; } = default!;

    /// <summary>
    /// Gets or sets data associated with the Elo update event.
    /// </summary>
    public EloUpdateEventData EventData { get; set; } = new EloUpdateEventData();
}

/// <summary>
/// Data associated with an Elo update event.
/// </summary>
public class EloUpdateEventData
{
    /// <summary>
    /// Gets or sets unique identifier for the comparison.
    /// </summary>
    public Guid ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets number of users whose Elo was updated.
    /// </summary>
    public int UsersUpdated { get; set; }

    /// <summary>
    /// Gets or sets list of results for each user update.
    /// </summary>
    public List<EloUpdateResult> UpdateResults { get; set; } = [];
}

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

/// <summary>
/// Response after notifying about an Elo update event.
/// </summary>
public class EloUpdateNotificationResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the notification was acknowledged.
    /// </summary>
    public bool Acknowledged { get; set; }

    /// <summary>
    /// Gets or sets workflow action to be taken after notification.
    /// </summary>
    public string WorkflowAction { get; set; } = default!;
}
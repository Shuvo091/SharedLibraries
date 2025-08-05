namespace SharedLibrary.Contracts.Usermanagement.Requests;

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

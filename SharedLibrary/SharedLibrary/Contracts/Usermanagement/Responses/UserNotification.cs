namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Notification details for a user affected by an Elo update.
/// </summary>
public class UserNotification
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets type of notification.
    /// </summary>
    public string NotificationType { get; set; } = default!;

    /// <summary>
    /// Gets or sets notification message.
    /// </summary>
    public string Message { get; set; } = default!;
}
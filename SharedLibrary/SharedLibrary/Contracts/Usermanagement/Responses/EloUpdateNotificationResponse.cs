namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response containing Elo update notification from workflow.
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
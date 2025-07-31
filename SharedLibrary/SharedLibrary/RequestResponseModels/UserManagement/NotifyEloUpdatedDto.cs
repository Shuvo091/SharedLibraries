namespace SharedLibrary.RequestResponseModels.UserManagement;


#region Elo Update Notification Request

public class EloUpdateNotificationRequest
{
    public string EventType { get; set; } = default!;
    public string UpdateId { get; set; } = default!;
    public EloUpdateEventData EventData { get; set; } = new EloUpdateEventData();
}

public class EloUpdateEventData
{
    public Guid ComparisonId { get; set; }
    public int UsersUpdated { get; set; }
    public List<EloUpdateResult> UpdateResults { get; set; } = [];
}

public class EloUpdateResult
{
    public Guid UserId { get; set; }
    public int NewElo { get; set; }
    public int Change { get; set; }
}

#endregion

#region Elo Update Notification Response

public class EloUpdateNotificationResponse
{
    public bool Acknowledged { get; set; }
    public string WorkflowAction { get; set; } = default!;
}

#endregion
namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Response containing professional status information for a batch of users.
/// </summary>
public class ProfessionalStatusBatchResponse
{
    /// <summary>
    /// Gets or sets dictionary mapping user identifiers to their professional status.
    /// </summary>
    public Dictionary<string, ProfessionalStatus> ProfessionalStatuses { get; set; } = new Dictionary<string, ProfessionalStatus>();

    /// <summary>
    /// Gets or sets summary of professional status statistics.
    /// </summary>
    public ProfessionalSummary Summary { get; set; } = new ProfessionalSummary();
}

/// <summary>
/// Professional status information for a user.
/// </summary>
public class ProfessionalStatus
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is a professional.
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if QA comparison is bypassed for the user.
    /// </summary>
    public bool BypassQAComparison { get; set; }
}

/// <summary>
/// Summary of professional status statistics for a batch.
/// </summary>
public class ProfessionalSummary
{
    /// <summary>
    /// Gets or sets total number of users checked.
    /// </summary>
    public int TotalChecked { get; set; }

    /// <summary>
    /// Gets or sets number of users who are professionals.
    /// </summary>
    public int Professionals { get; set; }

    /// <summary>
    /// Gets or sets number of users who are standard transcribers.
    /// </summary>
    public int StandardTranscribers { get; set; }
}
namespace SharedLibrary.Contracts.Usermanagement.Responses;

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

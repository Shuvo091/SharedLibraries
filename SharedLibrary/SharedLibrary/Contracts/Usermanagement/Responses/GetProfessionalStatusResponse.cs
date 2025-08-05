namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response containing the professional status of a user.
/// </summary>
public class GetProfessionalStatusResponse
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is a professional.
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets details about the user's professional status (if professional).
    /// </summary>
    public ProfessionalDetailsDto? ProfessionalDetails { get; set; }

    /// <summary>
    /// Gets or sets current role of the user (if not professional).
    /// </summary>
    public string? CurrentRole { get; set; }

    /// <summary>
    /// Gets or sets indicates if the user is eligible for professional status.
    /// </summary>
    public bool? EligibleForProfessional { get; set; }

    /// <summary>
    /// Gets or sets criteria for professional eligibility (if not professional).
    /// </summary>
    public EligibilityCriteriaDto? EligibilityCriteria { get; set; }

    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int CurrentElo { get; set; }

    /// <summary>
    /// Gets or sets total number of jobs completed by the user.
    /// </summary>
    public int? TotalJobsCompleted { get; set; }
}

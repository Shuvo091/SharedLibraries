namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Details about a user's professional status.
/// </summary>
public class ProfessionalDetailsDto
{
    /// <summary>
    /// Gets or sets professional designation.
    /// </summary>
    public string Designation { get; set; } = default!;

    /// <summary>
    /// Gets or sets professional level.
    /// </summary>
    public string Level { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether indicates if QA comparison is bypassed.
    /// </summary>
    public bool BypassQAComparison { get; set; }

    /// <summary>
    /// Gets or sets date and time when designated as professional.
    /// </summary>
    public DateTime DesignatedAt { get; set; }

    /// <summary>
    /// Gets or sets name of the person who designated the user.
    /// </summary>
    public string DesignatedBy { get; set; } = default!;
}

/// <summary>
/// Criteria for professional eligibility.
/// </summary>
public class EligibilityCriteriaDto
{
    /// <summary>
    /// Gets or sets minimum Elo required for professional status.
    /// </summary>
    public int MinEloRequired { get; set; }

    /// <summary>
    /// Gets or sets minimum number of jobs required for professional status.
    /// </summary>
    public int MinJobsRequired { get; set; }

    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int UserElo { get; set; }

    /// <summary>
    /// Gets or sets number of jobs completed by the user.
    /// </summary>
    public int UserJobs { get; set; }
}
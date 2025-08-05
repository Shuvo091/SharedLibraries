namespace SharedLibrary.Contracts.Usermanagement.Responses;

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

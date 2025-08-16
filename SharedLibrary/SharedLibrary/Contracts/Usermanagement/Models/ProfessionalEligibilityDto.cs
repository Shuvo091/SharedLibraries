namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Professional eligibility details for a user.
/// </summary>
public class ProfessionalEligibilityDto
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is eligible for professional status.
    /// </summary>
    public bool Eligible { get; set; }

    /// <summary>
    /// Gets or sets list of missing criteria for professional status.
    /// </summary>
    public List<string> MissingCriteria { get; set; } = [];

    /// <summary>
    /// Gets or sets progress towards professional status.
    /// </summary>
    public ProfessionalProgressDto Progress { get; set; } = new ();
}

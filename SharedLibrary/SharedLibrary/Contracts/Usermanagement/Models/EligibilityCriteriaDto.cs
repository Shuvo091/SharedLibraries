namespace SharedLibrary.Contracts.Usermanagement.Models;

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
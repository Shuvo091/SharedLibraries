namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response containing user profile information.
/// </summary>
public class UserProfileResponse
{
    /// <summary>
    /// Gets or sets user's first name.
    /// </summary>
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's last name.
    /// </summary>
    public string LastName { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's current Elo rating.
    /// </summary>
    public int EloRating { get; set; }

    /// <summary>
    /// Gets or sets user's peak Elo rating.
    /// </summary>
    public int PeakElo { get; set; }

    /// <summary>
    /// Gets or sets user's current status.
    /// </summary>
    public string Status { get; set; } = default!;

    /// <summary>
    /// Gets or sets date and time when the user registered.
    /// </summary>
    public DateTime RegisteredAt { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is a professional.
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets professional eligibility details for the user.
    /// </summary>
    public ProfessionalEligibilityDto ProfessionalEligibility { get; set; } = new ();

    /// <summary>
    /// Gets or sets user's statistics.
    /// </summary>
    public UserStatisticsDto Statistics { get; set; } = new ();

    /// <summary>
    /// Gets or sets user's preferences.
    /// </summary>
    public UserPreferencesDto Preferences { get; set; } = new ();
}

namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Progress details towards professional status.
/// </summary>
public class ProfessionalProgressDto
{
    /// <summary>
    /// Gets or sets progress in Elo rating.
    /// </summary>
    public string EloProgress { get; set; } = default!;

    /// <summary>
    /// Gets or sets progress in jobs completed.
    /// </summary>
    public string JobsProgress { get; set; } = default!;
}

/// <summary>
/// User statistics data transfer object.
/// </summary>
public class UserStatisticsDto
{
    /// <summary>
    /// Gets or sets total number of jobs completed by the user.
    /// </summary>
    public int TotalJobsCompleted { get; set; }

    /// <summary>
    /// Gets or sets number of games played by the user.
    /// </summary>
    public int GamesPlayed { get; set; }

    /// <summary>
    /// Gets or sets trend in Elo rating.
    /// </summary>
    public string EloTrend { get; set; } = default!;

    /// <summary>
    /// Gets or sets list of dialects the user is expert in.
    /// </summary>
    public List<string> DialectExpertise { get; set; } = [];

    /// <summary>
    /// Gets or sets user's win rate.
    /// </summary>
    public double WinRate { get; set; }

    /// <summary>
    /// Gets or sets statistics for the last 30 days.
    /// </summary>
    public Last30DaysStatsDto Last30Days { get; set; } = new ();
}

/// <summary>
/// Statistics for the last 30 days.
/// </summary>
public class Last30DaysStatsDto
{
    /// <summary>
    /// Gets or sets number of jobs completed in the last 30 days.
    /// </summary>
    public int JobsCompleted { get; set; }

    /// <summary>
    /// Gets or sets elo change in the last 30 days.
    /// </summary>
    public string EloChange { get; set; } = default!;

    /// <summary>
    /// Gets or sets earnings in the last 30 days.
    /// </summary>
    public double Earnings { get; set; }
}

/// <summary>
/// User preferences data transfer object.
/// </summary>
public class UserPreferencesDto
{
    /// <summary>
    /// Gets or sets maximum number of concurrent jobs allowed for the user.
    /// </summary>
    public int MaxConcurrentJobs { get; set; }

    /// <summary>
    /// Gets or sets list of dialect preferences for the user.
    /// </summary>
    public List<string> DialectPreferences { get; set; } = [];

    /// <summary>
    /// Gets or sets list of preferred job types for the user.
    /// </summary>
    public List<string> PreferredJobTypes { get; set; } = [];
}
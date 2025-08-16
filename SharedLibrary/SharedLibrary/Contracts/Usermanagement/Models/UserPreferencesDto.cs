namespace SharedLibrary.Contracts.Usermanagement.Models;

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
namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response after updating verification requirements.
/// </summary>
public class UpdateVerificationRequirementsResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether the requirements were updated.
    /// </summary>
    public bool RequirementsUpdated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether PII data collection is enabled.
    /// </summary>
    public bool PiiDataCollection { get; set; }

    /// <summary>
    /// Gets or sets the compliance mode in effect.
    /// </summary>
    public string ComplianceMode { get; set; } = default!;

    /// <summary>
    /// Gets or sets the verification level after update.
    /// </summary>
    public string VerificationLevel { get; set; } = default!;

    /// <summary>
    /// Gets or sets the list of verification steps required.
    /// </summary>
    public List<string> VerificationSteps { get; set; } = new List<string>();

    /// <summary>
    /// Gets or sets the roadmap enhancements as a dictionary.
    /// </summary>
    public Dictionary<string, string> RoadmapEnhancements { get; set; } = new Dictionary<string, string>();
}
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Request to update verification requirements for user onboarding or compliance.
/// </summary>
public class UpdateVerificationRequirementsRequest
{
    /// <summary>
    /// Gets or sets a value indicating whether an ID document is required.
    /// </summary>
    public bool RequireIdDocument { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a photo upload is required.
    /// </summary>
    public bool RequirePhotoUpload { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether phone verification is required.
    /// </summary>
    public bool RequirePhoneVerification { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether email verification is required.
    /// </summary>
    public bool RequireEmailVerification { get; set; }

    /// <summary>
    /// Gets or sets the verification level required.
    /// </summary>
    [Required(ErrorMessage = "VerificationLevel is required.")]
    [MinLength(1, ErrorMessage = "VerificationLevel cannot be empty.")]
    public string VerificationLevel { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the dictionary of validation rules.
    /// </summary>
    [Required(ErrorMessage = "ValidationRules dictionary is required.")]
    [MinLength(1, ErrorMessage = "ValidationRules must contain at least one rule.")]
    public Dictionary<string, string> ValidationRules { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// Gets or sets the reason for updating verification requirements.
    /// </summary>
    [Required(ErrorMessage = "Reason is required.")]
    [MinLength(1, ErrorMessage = "Reason cannot be empty.")]
    public string Reason { get; set; } = string.Empty;
}

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
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

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
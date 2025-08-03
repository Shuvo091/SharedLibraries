using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Request to perform user verification.
/// </summary>
public class VerificationRequest
{
    /// <summary>
    /// Gets or sets the type of verification requested.
    /// </summary>
    [Required(ErrorMessage = "VerificationType is required.")]
    [MinLength(1, ErrorMessage = "VerificationType cannot be empty.")]
    public string VerificationType { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ID document validation details.
    /// </summary>
    [Required(ErrorMessage = "IdDocumentValidation is required.")]
    public IdDocumentValidationDto IdDocumentValidation { get; set; } = new IdDocumentValidationDto();

    /// <summary>
    /// Gets or sets additional verification details.
    /// </summary>
    [Required(ErrorMessage = "AdditionalVerification is required.")]
    public AdditionalVerificationDto AdditionalVerification { get; set; } = new AdditionalVerificationDto();
}

/// <summary>
/// Data transfer object for ID document validation.
/// </summary>
public class IdDocumentValidationDto
{
    /// <summary>
    /// Gets or sets a value indicating whether validation is enabled.
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// Gets or sets the ID number to validate.
    /// </summary>
    [Required(ErrorMessage = "IdNumber is required when validation is enabled.")]
    [MinLength(1, ErrorMessage = "IdNumber cannot be empty.")]
    public string IdNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether a photo was uploaded.
    /// </summary>
    public bool PhotoUploaded { get; set; }

    /// <summary>
    /// Gets or sets the validation result details.
    /// </summary>
    [Required(ErrorMessage = "ValidationResult is required.")]
    public ValidationResultDto ValidationResult { get; set; } = new ValidationResultDto();
}

/// <summary>
/// Data transfer object for validation result details.
/// </summary>
public class ValidationResultDto
{
    /// <summary>
    /// Gets or sets a value indicating whether the ID format is valid.
    /// </summary>
    public bool IdFormatValid { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a photo is present.
    /// </summary>
    public bool PhotoPresent { get; set; }

    /// <summary>
    /// Gets or sets an optional note about the validation.
    /// </summary>
    public string? Note { get; set; }
}

/// <summary>
/// Data transfer object for additional verification options.
/// </summary>
public class AdditionalVerificationDto
{
    /// <summary>
    /// Gets or sets a value indicating whether phone verification is required.
    /// </summary>
    public bool PhoneVerification { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether email verification is required.
    /// </summary>
    public bool EmailVerification { get; set; }
}

/// <summary>
/// Response after performing user verification.
/// </summary>
public class VerificationResponse
{
    /// <summary>
    /// Gets or sets the verification status.
    /// </summary>
    public string VerificationStatus { get; set; } = default!;

    /// <summary>
    /// Gets or sets the user's Elo rating after verification.
    /// </summary>
    public int EloRating { get; set; }

    /// <summary>
    /// Gets or sets the status change message.
    /// </summary>
    public string StatusChanged { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the user is eligible for work.
    /// </summary>
    public bool EligibleForWork { get; set; }

    /// <summary>
    /// Gets or sets the activation method used.
    /// </summary>
    public string ActivationMethod { get; set; } = default!;

    /// <summary>
    /// Gets or sets the date and time when the user was activated.
    /// </summary>
    public DateTime ActivatedAt { get; set; }

    /// <summary>
    /// Gets or sets the verification level achieved.
    /// </summary>
    public string VerificationLevel { get; set; } = default!;

    /// <summary>
    /// Gets or sets the next steps for the user.
    /// </summary>
    public string[] NextSteps { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets a note about the roadmap for the user.
    /// </summary>
    public string RoadmapNote { get; set; } = default!;
}
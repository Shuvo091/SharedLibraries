using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

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

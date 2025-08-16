using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Verification details for professional status.
/// </summary>
public class ProfessionalVerificationDto
{
    /// <summary>
    /// Gets or sets list of verification documents.
    /// </summary>
    [Required(ErrorMessage = "VerificationDocuments is required.")]
    [MinLength(1, ErrorMessage = "At least one verification document is required.")]
    public List<string> VerificationDocuments { get; set; } = new ();

    /// <summary>
    /// Gets or sets professional level of the user.
    /// </summary>
    [Required(ErrorMessage = "ProfessionalLevel is required.")]
    [MinLength(1, ErrorMessage = "ProfessionalLevel cannot be empty.")]
    public string ProfessionalLevel { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether indicates if QA comparison is bypassed for the user.
    /// </summary>
    public bool BypassQAComparison { get; set; }
}
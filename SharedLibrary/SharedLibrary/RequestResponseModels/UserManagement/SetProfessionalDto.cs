using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Request to set a user's professional status.
/// </summary>
public class SetProfessionalRequest
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is to be set as professional.
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets verification details for professional status.
    /// </summary>
    [Required(ErrorMessage = "ProfessionalVerification is required.")]
    public ProfessionalVerificationDto ProfessionalVerification { get; set; } = new ();

    /// <summary>
    /// Gets or sets unique identifier for the authorizing user.
    /// </summary>
    [Required(ErrorMessage = "AuthorizedBy is required.")]
    public Guid AuthorizedBy { get; set; }
}

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

/// <summary>
/// Response after setting a user's professional status.
/// </summary>
public class SetProfessionalResponse
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user's role was updated.
    /// </summary>
    public bool RoleUpdated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is now a professional.
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets user's previous role.
    /// </summary>
    public string PreviousRole { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's new role.
    /// </summary>
    public string NewRole { get; set; } = default!;

    /// <summary>
    /// Gets or sets date and time from which the new role is effective.
    /// </summary>
    public DateTime EffectiveFrom { get; set; } = DateTime.UtcNow;
}
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

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

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Set Professional Request
public class SetProfessionalRequest
{
	public bool IsProfessional { get; set; }

	[Required(ErrorMessage = "ProfessionalVerification is required.")]
	public ProfessionalVerificationDto ProfessionalVerification { get; set; } = new();

	[Required(ErrorMessage = "AuthorizedBy is required.")]
	public Guid AuthorizedBy { get; set; }
}

public class ProfessionalVerificationDto
{
	[Required(ErrorMessage = "VerificationDocuments is required.")]
	[MinLength(1, ErrorMessage = "At least one verification document is required.")]
	public List<string> VerificationDocuments { get; set; } = new();

	[Required(ErrorMessage = "ProfessionalLevel is required.")]
	[MinLength(1, ErrorMessage = "ProfessionalLevel cannot be empty.")]
	public string ProfessionalLevel { get; set; } = string.Empty;

	public bool BypassQAComparison { get; set; }
}


#endregion


#region Set Professional Response

public class SetProfessionalResponse
{
    public Guid UserId { get; set; }
    public bool RoleUpdated { get; set; }
    public bool IsProfessional { get; set; }
    public string PreviousRole { get; set; } = default!;
    public string NewRole { get; set; } = default!;
    public DateTime EffectiveFrom { get; set; } = DateTime.UtcNow;
}

#endregion
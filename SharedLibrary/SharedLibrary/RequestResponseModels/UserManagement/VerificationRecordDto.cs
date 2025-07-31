using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;


#region Verification Request

public class VerificationRequest
{
	[Required(ErrorMessage = "VerificationType is required.")]
	[MinLength(1, ErrorMessage = "VerificationType cannot be empty.")]
	public string VerificationType { get; set; } = string.Empty;

	[Required(ErrorMessage = "IdDocumentValidation is required.")]
	public IdDocumentValidationDto IdDocumentValidation { get; set; } = new IdDocumentValidationDto();

	[Required(ErrorMessage = "AdditionalVerification is required.")]
	public AdditionalVerificationDto AdditionalVerification { get; set; } = new AdditionalVerificationDto();
}

public class IdDocumentValidationDto
{
	public bool Enabled { get; set; }

	[Required(ErrorMessage = "IdNumber is required when validation is enabled.")]
	[MinLength(1, ErrorMessage = "IdNumber cannot be empty.")]
	public string IdNumber { get; set; } = string.Empty;

	public bool PhotoUploaded { get; set; }

	[Required(ErrorMessage = "ValidationResult is required.")]
	public ValidationResultDto ValidationResult { get; set; } = new ValidationResultDto();
}

public class ValidationResultDto
{
	public bool IdFormatValid { get; set; }
	public bool PhotoPresent { get; set; }
	public string? Note { get; set; }
}

public class AdditionalVerificationDto
{
	public bool PhoneVerification { get; set; }
	public bool EmailVerification { get; set; }
}

#endregion

#region Verification Response

public class VerificationResponse
{
    public string VerificationStatus { get; set; } = default!;
    public int EloRating { get; set; }
    public string StatusChanged { get; set; } = default!;
    public bool EligibleForWork { get; set; }
    public string ActivationMethod { get; set; } = default!;
    public DateTime ActivatedAt { get; set; }
    public string VerificationLevel { get; set; } = default!;
    public string[] NextSteps { get; set; } = [];
    public string RoadmapNote { get; set; } = default!;
}

#endregion
namespace SharedLibrary.RequestResponseModels.UserManagement;


#region Verification Request

public class VerificationRequest
{
    public string VerificationType { get; set; } = default!;
    public IdDocumentValidationDto IdDocumentValidation { get; set; } = new IdDocumentValidationDto();
    public AdditionalVerificationDto AdditionalVerification { get; set; } = new AdditionalVerificationDto();
}

public class IdDocumentValidationDto
{
    public bool Enabled { get; set; }
    public string IdNumber { get; set; } = default!;
    public bool PhotoUploaded { get; set; }
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
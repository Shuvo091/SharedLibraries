namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Set Professional Request
public class SetProfessionalRequest
{
    public bool IsProfessional { get; set; }
    public ProfessionalVerificationDto ProfessionalVerification { get; set; } = new();
    public Guid AuthorizedBy { get; set; } = default!;
}

public class ProfessionalVerificationDto
{
    public List<string> VerificationDocuments { get; set; } = [];
    public string ProfessionalLevel { get; set; } = default!;
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
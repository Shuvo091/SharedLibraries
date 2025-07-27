namespace SharedLibrary.RequestResponseModels.UserManagement;

public class GetProfessionalStatusResponse
{
	public Guid UserId { get; set; }
	public bool IsProfessional { get; set; }

	// Populated if IsProfessional == true
	public ProfessionalDetailsDto? ProfessionalDetails { get; set; }

	// Populated if IsProfessional == false
	public string? CurrentRole { get; set; }
	public bool? EligibleForProfessional { get; set; }
	public EligibilityCriteriaDto? EligibilityCriteria { get; set; }

	public int CurrentElo { get; set; }
	public int? TotalJobsCompleted { get; set; }
}

public class ProfessionalDetailsDto
{
	public string Designation { get; set; } = default!;
	public string Level { get; set; } = default!;
	public bool BypassQAComparison { get; set; }
	public DateTime DesignatedAt { get; set; }
	public string DesignatedBy { get; set; } = default!;
}

public class EligibilityCriteriaDto
{
	public int MinEloRequired { get; set; }
	public int MinJobsRequired { get; set; }
	public int UserElo { get; set; }
	public int UserJobs { get; set; }
}

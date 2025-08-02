namespace SharedLibrary.RequestResponseModels.UserManagement;

public class ProfessionalStatusBatchResponse
{
	public Dictionary<string, ProfessionalStatus> ProfessionalStatuses { get; set; } = new Dictionary<string, ProfessionalStatus>();
	public ProfessionalSummary Summary { get; set; } = new ProfessionalSummary();
}

public class ProfessionalStatus
{
	public bool IsProfessional { get; set; }
	public bool BypassQAComparison { get; set; }
}

public class ProfessionalSummary
{
	public int TotalChecked { get; set; }
	public int Professionals { get; set; }
	public int StandardTranscribers { get; set; }
}

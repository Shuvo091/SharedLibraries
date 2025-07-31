using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;


#region Claim Job Request

public class ClaimJobRequest
{
	[Required(ErrorMessage = "JobId is required.")]
	public string JobId { get; set; } = default!;

	[Required(ErrorMessage = "ClaimTimestamp is required.")]
	public DateTime ClaimTimestamp { get; set; }

	[Required(ErrorMessage = "WorkflowRequestId is required.")]
	public string WorkflowRequestId { get; set; } = default!;

	[Required(ErrorMessage = "JobMetadata is required.")]
	public JobMetadataDto JobMetadata { get; set; } = default!;
}

public class JobMetadataDto
{
    public string Dialect { get; set; } = default!;
    public string EstimatedDuration { get; set; } = default!; // e.g. "4m30s"

	[Range(1, int.MaxValue, ErrorMessage = "TranscriptionSequence must be a positive number.")]
	public int TranscriptionSequence { get; set; }
}

#endregion

#region Claim Job Response

public class ClaimJobResponse
{
    public bool ClaimValidated { get; set; }
    public bool UserEligible { get; set; }
    public Guid ClaimId { get; set; } = default!;
    public string UserAvailability { get; set; } = default!;
    //public bool IsProfessional { get; set; } // To get this info we have to hit database. That is not wanted here
    //public bool BypassQARequired { get; set; }
    public int CurrentWorkload { get; set; }
    public int MaxConcurrentJobs { get; set; }
    public DateTime CapacityReservedUntil { get; set; }
}

#endregion
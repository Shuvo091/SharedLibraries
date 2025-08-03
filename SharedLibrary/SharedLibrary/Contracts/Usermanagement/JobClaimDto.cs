using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

/// <summary>
/// Request to claim a job for transcription.
/// </summary>
public class ClaimJobRequest
{
    /// <summary>
    /// Gets or sets unique identifier for the job.
    /// </summary>
    [Required(ErrorMessage = "JobId is required.")]
    public string JobId { get; set; } = default!;

    /// <summary>
    /// Gets or sets timestamp when the job was claimed.
    /// </summary>
    [Required(ErrorMessage = "ClaimTimestamp is required.")]
    public DateTime ClaimTimestamp { get; set; }

    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    [Required(ErrorMessage = "WorkflowRequestId is required.")]
    public string WorkflowRequestId { get; set; } = default!;

    /// <summary>
    /// Gets or sets metadata about the job being claimed.
    /// </summary>
    [Required(ErrorMessage = "JobMetadata is required.")]
    public JobMetadataDto JobMetadata { get; set; } = default!;
}

/// <summary>
/// Metadata about a job being claimed.
/// </summary>
public class JobMetadataDto
{
    /// <summary>
    /// Gets or sets dialect for the job.
    /// </summary>
    public string Dialect { get; set; } = default!;

    /// <summary>
    /// Gets or sets estimated duration of the job (e.g., "4m30s").
    /// </summary>
    public string EstimatedDuration { get; set; } = default!; // e.g. "4m30s"

    /// <summary>
    /// Gets or sets sequence number for transcription.
    /// </summary>
    [Range(1, int.MaxValue, ErrorMessage = "TranscriptionSequence must be a positive number.")]
    public int TranscriptionSequence { get; set; }
}

/// <summary>
/// Response after claiming a job.
/// </summary>
public class ClaimJobResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the claim was validated.
    /// </summary>
    public bool ClaimValidated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is eligible for the job.
    /// </summary>
    public bool UserEligible { get; set; }

    /// <summary>
    /// Gets or sets unique identifier for the claim.
    /// </summary>
    public Guid ClaimId { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's availability status.
    /// </summary>
    public string UserAvailability { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's current workload.
    /// </summary>
    public int CurrentWorkload { get; set; }

    /// <summary>
    /// Gets or sets maximum number of concurrent jobs allowed for the user.
    /// </summary>
    public int MaxConcurrentJobs { get; set; }

    /// <summary>
    /// Gets or sets time until which the user's capacity is reserved.
    /// </summary>
    public DateTime CapacityReservedUntil { get; set; }
}
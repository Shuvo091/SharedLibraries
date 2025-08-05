using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

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

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Models;

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

using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents an available transcription job.
    /// </summary>
    public class AvailableJobResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// Gets or sets the URI of the audio file.
        /// </summary>
        public string? AudioUri { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the job.
        /// </summary>
        public AvailableJobAudioMetadataResponse? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers needed for the job.
        /// </summary>
        public int? TranscribersNeeded { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers currently assigned.
        /// </summary>
        public int? TranscribersAssigned { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        public string? Priority { get; set; }

        /// <summary>
        /// Gets or sets the workflow strategy for the job.
        /// </summary>
        public string? WorkflowStrategy { get; set; }

        /// <summary>
        /// Gets or sets the book out timeout in hours.
        /// </summary>
        public int? BookOutTimeoutHours { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration for the job.
        /// </summary>
        public AvailableJobDialectConfigResponse? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether open access is enabled for the job.
        /// </summary>
        public bool? OpenAccessEnabled { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }
    }
}
using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents a claimed transcription job.
    /// </summary>
    public class ClaimedJobResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the status of the claimed job.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the claimed job.
        /// </summary>
        public ClaimedJobAudioMetadataResponse? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was claimed.
        /// </summary>
        public DateTime? ClaimedAt { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the claimed job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the progress percentage of the claimed job.
        /// </summary>
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets the book out timeout for the claimed job.
        /// </summary>
        public DateTime? BookOutTimeout { get; set; }
    }
}
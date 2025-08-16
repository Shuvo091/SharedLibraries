using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response after creating a transcription job.
    /// </summary>
    public class CreateTranscriptionJobResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// Gets or sets the status of the job creation.
        /// </summary>
        public string? Status { get; set; }

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
        /// Gets or sets the URI of the job.
        /// </summary>
        public string? JobUri { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration for the job.
        /// </summary>
        public CreateTranscriptionJobDialectConfigResponse? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether open access is enabled for the job.
        /// </summary>
        public bool? OpenAccessEnabled { get; set; }
    }
}
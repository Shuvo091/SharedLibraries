namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents metadata for a job.
    /// </summary>
    public class JobStateJobMetadataResponse
    {
        /// <summary>
        /// Gets or sets the date and time when the job was created.
        /// </summary>
        public DateTime? JobCreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the dialect for the job.
        /// </summary>
        public string? Dialect { get; set; }
    }
}
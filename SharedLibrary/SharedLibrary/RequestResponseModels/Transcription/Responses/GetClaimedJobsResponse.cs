namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing claimed transcription jobs.
    /// </summary>
    public class GetClaimedJobsResponse
    {
        /// <summary>
        /// Gets or sets the list of claimed jobs.
        /// </summary>
        public List<ClaimedJobResponse>? ClaimedJobs { get; set; }

        /// <summary>
        /// Gets or sets the total number of claimed jobs.
        /// </summary>
        public int? TotalClaimed { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the query was made.
        /// </summary>
        public DateTime? QueryTimestamp { get; set; }
    }

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

    /// <summary>
    /// Represents audio metadata for a claimed job.
    /// </summary>
    public class ClaimedJobAudioMetadataResponse
    {
        /// <summary>
        /// Gets or sets the duration of the audio file.
        /// </summary>
        public string? Duration { get; set; }

        /// <summary>
        /// Gets or sets the dialect of the audio file.
        /// </summary>
        public string? Dialect { get; set; }
    }
}
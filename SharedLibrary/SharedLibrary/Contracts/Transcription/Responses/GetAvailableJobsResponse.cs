namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing available transcription jobs.
    /// </summary>
    public class GetAvailableJobsResponse
    {
        /// <summary>
        /// Gets or sets the list of available jobs.
        /// </summary>
        public List<AvailableJobResponse>? AvailableJobs { get; set; }

        /// <summary>
        /// Gets or sets the total number of available jobs.
        /// </summary>
        public int? TotalAvailable { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the query was made.
        /// </summary>
        public DateTime? QueryTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the filters applied to the available jobs query.
        /// </summary>
        public AvailableJobFiltersResponse? Filters { get; set; }
    }

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

    /// <summary>
    /// Represents filters applied to available jobs.
    /// </summary>
    public class AvailableJobFiltersResponse
    {
        /// <summary>
        /// Gets or sets the dialect filter.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether jobs need transcribers.
        /// </summary>
        public bool? NeedsTranscribers { get; set; }
    }

    /// <summary>
    /// Represents audio metadata for an available job.
    /// </summary>
    public class AvailableJobAudioMetadataResponse
    {
        /// <summary>
        /// Gets or sets the duration of the audio file.
        /// </summary>
        public string? Duration { get; set; }

        /// <summary>
        /// Gets or sets the dialect of the audio file.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets the file size of the audio file.
        /// </summary>
        public string? FileSize { get; set; }

        /// <summary>
        /// Gets or sets the estimated difficulty of the job.
        /// </summary>
        public string? EstimatedDifficulty { get; set; }
    }

    /// <summary>
    /// Represents the dialect configuration for an available job.
    /// </summary>
    public class AvailableJobDialectConfigResponse
    {
        /// <summary>
        /// Gets or sets the language of the dialect.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// Gets or sets the variant of the dialect.
        /// </summary>
        public string? Variant { get; set; }
    }
}
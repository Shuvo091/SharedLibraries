namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing the state of a transcription job.
    /// </summary>
    public class GetJobStateResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the current state of the job.
        /// </summary>
        public string? CurrentState { get; set; }

        /// <summary>
        /// Gets or sets the transcription progress for the job.
        /// </summary>
        public JobStateTranscriptionProgressResponse? TranscriptionProgress { get; set; }

        /// <summary>
        /// Gets or sets the workflow decision for the job.
        /// </summary>
        public JobStateWorkflowDecisionResponse? WorkflowDecision { get; set; }

        /// <summary>
        /// Gets or sets the metadata for the job.
        /// </summary>
        public JobStateJobMetadataResponse? Metadata { get; set; }
    }

    /// <summary>
    /// Represents the transcription progress for a job.
    /// </summary>
    public class JobStateTranscriptionProgressResponse
    {
        /// <summary>
        /// Gets or sets the number of transcriptions needed.
        /// </summary>
        public int? Needed { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions completed.
        /// </summary>
        public int? Completed { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions in progress.
        /// </summary>
        public int? InProgress { get; set; }

        /// <summary>
        /// Gets or sets the list of completed transcriptions.
        /// </summary>
        public List<JobStateCompletedTranscriptionResponse>? CompletedTranscriptions { get; set; }
    }

    /// <summary>
    /// Represents the workflow decision for a job.
    /// </summary>
    public class JobStateWorkflowDecisionResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the job is ready for comparison.
        /// </summary>
        public bool? ReadyForComparison { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a professional bypass is required.
        /// </summary>
        public bool? RequiresProfessionalBypass { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a tiebreaker is required.
        /// </summary>
        public bool? RequiresTiebreaker { get; set; }

        /// <summary>
        /// Gets or sets the suggested action for the job.
        /// </summary>
        public string? SuggestedAction { get; set; }

        /// <summary>
        /// Gets or sets the estimated ready time for the job.
        /// </summary>
        public DateTime? EstimatedReadyTime { get; set; }
    }

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

    /// <summary>
    /// Represents a completed transcription for a job.
    /// </summary>
    public class JobStateCompletedTranscriptionResponse
    {
        /// <summary>
        /// Gets or sets the transcription identifier.
        /// </summary>
        public Guid? TranscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the transcriber identifier.
        /// </summary>
        public Guid? TranscriberId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transcription was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transcriber is a professional.
        /// </summary>
        public bool? IsProfessional { get; set; }
    }
}
namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing details of a transcription job.
    /// </summary>
    public class GetJobResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// Gets or sets the status of the job.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the URI of the audio file.
        /// </summary>
        public string? AudioUri { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the job.
        /// </summary>
        public TranscriptionJobAudioMetadataResponse? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the list of transcribers for the job.
        /// </summary>
        public List<TranscriptionJobTranscriberResponse>? Transcribers { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers needed for the job.
        /// </summary>
        public int? TranscribersNeeded { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is for professionals only.
        /// </summary>
        public bool? ProfessionalOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether QA comparison is bypassed.
        /// </summary>
        public bool? BypassQaComparison { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the progress percentage of the job.
        /// </summary>
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI comparison response for the job.
        /// </summary>
        public TranscriptionJobOpenaiComparisonResponse? OpenaiComparison { get; set; }

        /// <summary>
        /// Gets or sets the current draft for the job.
        /// </summary>
        public TranscriptionJobCurrentDraftResponse? CurrentDraft { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration for the job.
        /// </summary>
        public TranscriptionJobDialectConfigResponse? DialectConfig { get; set; }
    }
}
namespace SharedLibrary.RequestResponseModels.Transcription.Responses
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

    /// <summary>
    /// Represents audio metadata for a transcription job.
    /// </summary>
    public class TranscriptionJobAudioMetadataResponse
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
        /// Gets or sets the format of the audio file.
        /// </summary>
        public string? Format { get; set; }
    }

    /// <summary>
    /// Represents a transcriber for a transcription job.
    /// </summary>
    public class TranscriptionJobTranscriberResponse
    {
        /// <summary>
        /// Gets or sets the user identifier of the transcriber.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets the sequence number of the transcriber.
        /// </summary>
        public int? Sequence { get; set; }

        /// <summary>
        /// Gets or sets the status of the transcriber.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the role of the transcriber.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was claimed by the transcriber.
        /// </summary>
        public DateTime? ClaimedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was completed by the transcriber.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }

    /// <summary>
    /// Represents the OpenAI comparison response for a transcription job.
    /// </summary>
    public class TranscriptionJobOpenaiComparisonResponse
    {
        /// <summary>
        /// Gets or sets the status of the OpenAI comparison.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is ready for comparison.
        /// </summary>
        public bool? ReadyForComparison { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a third transcriber is required.
        /// </summary>
        public bool? RequiresThirdTranscriber { get; set; }
    }

    /// <summary>
    /// Represents the current draft for a transcription job.
    /// </summary>
    public class TranscriptionJobCurrentDraftResponse
    {
        /// <summary>
        /// Gets or sets the text of the current draft.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the word count of the current draft.
        /// </summary>
        public int? WordCount { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the draft was last saved.
        /// </summary>
        public DateTime? LastSaved { get; set; }

        /// <summary>
        /// Gets or sets the version of the current draft.
        /// </summary>
        public int? Version { get; set; }
    }

    /// <summary>
    /// Represents the dialect configuration for a transcription job.
    /// </summary>
    public class TranscriptionJobDialectConfigResponse
    {
        /// <summary>
        /// Gets or sets the language of the dialect.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// Gets or sets the variant of the dialect.
        /// </summary>
        public string? Variant { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether spell check is enabled.
        /// </summary>
        public bool? SpellCheckEnabled { get; set; }
    }
}
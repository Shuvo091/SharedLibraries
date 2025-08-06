namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to create a new transcription job.
    /// </summary>
    public class CreateTranscriptionJobRequest
    {
        /// <summary>
        /// Gets or sets the URI of the audio file to be transcribed.
        /// </summary>
        public string? AudioUri { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the job.
        /// </summary>
        public TranscriptionJobAudioMetadataRequest? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the audio context metadata for the job.
        /// </summary>
        public TranscriptionJobAudioContextMetadataRequest? AudioMetaContextdata { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers needed for the job.
        /// </summary>
        public int? TranscribersNeeded { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the workflow strategy for the job.
        /// </summary>
        public string? WorkflowStrategy { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration for the job.
        /// </summary>
        public TranscriptionJobDialectConfigRequest? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI configuration for the job.
        /// </summary>
        public TranscriptionJobOpenaiConfigRequest? OpenaiConfig { get; set; }
    }

    /// <summary>
    /// Represents audio metadata for a transcription job.
    /// </summary>
    public class TranscriptionJobAudioMetadataRequest
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
        /// Gets or sets the quality score of the audio file.
        /// </summary>
        public float? QualityScore { get; set; }

        /// <summary>
        /// Gets or sets the estimated difficulty of the job.
        /// </summary>
        public string? EstimatedDifficulty { get; set; }
    }

    /// <summary>
    /// Represents audio metadata for a transcription job.
    /// </summary>
    public class TranscriptionJobAudioContextMetadataRequest
    {
        /// <summary>
        /// Gets or sets audio context job id.
        /// </summary>
        public string? AudioContextJobId { get; set; }

        /// <summary>
        /// Gets or sets the chunk Id.
        /// </summary>
        public string? ChunkId { get; set; }
    }

    /// <summary>
    /// Represents the dialect configuration for a transcription job.
    /// </summary>
    public class TranscriptionJobDialectConfigRequest
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

        /// <summary>
        /// Gets or sets the custom dictionary for the job.
        /// </summary>
        public string? CustomDictionary { get; set; }
    }

    /// <summary>
    /// Represents the OpenAI configuration for a transcription job.
    /// </summary>
    public class TranscriptionJobOpenaiConfigRequest
    {
        /// <summary>
        /// Gets or sets the similarity threshold for OpenAI comparison.
        /// </summary>
        public int? SimilarityThreshold { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a third transcriber is required.
        /// </summary>
        public bool? RequiresThirdTranscriber { get; set; }

        /// <summary>
        /// Gets or sets the language context for OpenAI processing.
        /// </summary>
        public string? LanguageContext { get; set; }
    }
}
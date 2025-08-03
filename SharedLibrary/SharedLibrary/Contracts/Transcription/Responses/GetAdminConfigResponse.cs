namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing admin configuration settings.
    /// </summary>
    public class GetAdminConfigResponse
    {
        /// <summary>
        /// Gets or sets the workflow configuration.
        /// </summary>
        public AdminWorkflowConfigResponse? WorkflowConfig { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI configuration.
        /// </summary>
        public AdminOpenaiConfigResponse? OpenaiConfig { get; set; }

        /// <summary>
        /// Gets or sets the access configuration.
        /// </summary>
        public AdminAccessConfigResponse? AccessConfig { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration.
        /// </summary>
        public AdminDialectConfigResponse? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets the quality configuration.
        /// </summary>
        public AdminQualityConfigResponse? QualityConfig { get; set; }

        /// <summary>
        /// Gets or sets the context audio configuration.
        /// </summary>
        public AdminContextAudioConfigResponse? ContextAudioConfig { get; set; }

        /// <summary>
        /// Gets or sets the integration configuration.
        /// </summary>
        public AdminIntegrationConfigResponse? IntegrationConfig { get; set; }
    }

    /// <summary>
    /// Represents workflow configuration settings for admin.
    /// </summary>
    public class AdminWorkflowConfigResponse
    {
        /// <summary>
        /// Gets or sets the auto-save interval.
        /// </summary>
        public string? AutoSaveInterval { get; set; }

        /// <summary>
        /// Gets or sets the job timeout in hours.
        /// </summary>
        public int? JobTimeoutHours { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of draft versions.
        /// </summary>
        public int? MaxDraftVersions { get; set; }

        /// <summary>
        /// Gets or sets the concurrent session limit.
        /// </summary>
        public int? ConcurrentSessionLimit { get; set; }

        /// <summary>
        /// Gets or sets the default number of transcribers per job.
        /// </summary>
        public int? DefaultTranscribersPerJob { get; set; }
    }

    /// <summary>
    /// Represents OpenAI configuration settings for admin.
    /// </summary>
    public class AdminOpenaiConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether OpenAI is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI model.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// Gets or sets the similarity threshold for OpenAI.
        /// </summary>
        public int? SimilarityThreshold { get; set; }

        /// <summary>
        /// Gets or sets the API timeout for OpenAI.
        /// </summary>
        public int? ApiTimeout { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of retries for OpenAI.
        /// </summary>
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to fallback to human.
        /// </summary>
        public bool? FallbackToHuman { get; set; }
    }

    /// <summary>
    /// Represents access configuration settings for admin.
    /// </summary>
    public class AdminAccessConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether open access is enabled.
        /// </summary>
        public bool? OpenAccessEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Elo-based job claiming is enabled.
        /// </summary>
        public bool? EloBasedJobClaiming { get; set; }

        /// <summary>
        /// Gets or sets the job difficulty removal setting.
        /// </summary>
        public string? RemoveJobDifficulty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether chess-style Elo is enabled.
        /// </summary>
        public bool? ChessStyleElo { get; set; }
    }

    /// <summary>
    /// Represents dialect configuration settings for admin.
    /// </summary>
    public class AdminDialectConfigResponse
    {
        /// <summary>
        /// Gets or sets the supported languages.
        /// </summary>
        public List<string>? SupportedLanguages { get; set; }

        /// <summary>
        /// Gets or sets the supported variants.
        /// </summary>
        public List<string>? SupportedVariants { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether extensibility for other languages is enabled.
        /// </summary>
        public bool? ExtensibleForOtherLanguages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether default spell check is enabled.
        /// </summary>
        public bool? DefaultSpellCheck { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether custom dictionaries are enabled.
        /// </summary>
        public bool? EnableCustomDictionaries { get; set; }
    }

    /// <summary>
    /// Represents quality configuration settings for admin.
    /// </summary>
    public class AdminQualityConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether auto quality check is enabled.
        /// </summary>
        public bool? EnableAutoQualityCheck { get; set; }

        /// <summary>
        /// Gets or sets the minimum quality score required for submission.
        /// </summary>
        public float? MinQualityScoreForSubmission { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dialect validation is enabled.
        /// </summary>
        public bool? EnableDialectValidation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether OpenAI-based quality assessment is enabled.
        /// </summary>
        public bool? OpenaiBasedQualityAssessment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether tiebreaker is enabled.
        /// </summary>
        public bool? TiebreakerEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Elo-based quality assessment is enabled.
        /// </summary>
        public bool? EloBasedQualityAssessment { get; set; }
    }

    /// <summary>
    /// Represents context audio configuration settings for admin.
    /// </summary>
    public class AdminContextAudioConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether context audio is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the default context window.
        /// </summary>
        public string? DefaultContextWindow { get; set; }

        /// <summary>
        /// Gets or sets the maximum concatenated duration.
        /// </summary>
        public string? MaxConcatenatedDuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether seamless transitions are enabled.
        /// </summary>
        public bool? SeamlessTransitions { get; set; }

        /// <summary>
        /// Gets or sets the supported audio formats.
        /// </summary>
        public List<string>? SupportedFormats { get; set; }

        /// <summary>
        /// Gets or sets the context cache expiry in hours.
        /// </summary>
        public int? ContextCacheExpiryHours { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether volume normalization is enabled.
        /// </summary>
        public bool? EnableVolumeNormalization { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of context requests per job.
        /// </summary>
        public int? MaxContextRequestsPerJob { get; set; }
    }

    /// <summary>
    /// Represents integration configuration settings for admin.
    /// </summary>
    public class AdminIntegrationConfigResponse
    {
        /// <summary>
        /// Gets or sets the user management API URL.
        /// </summary>
        public string? UserManagementApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the QA service API URL.
        /// </summary>
        public string? QaServiceApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the workflow engine API URL.
        /// </summary>
        public string? WorkflowEngineApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI API URL.
        /// </summary>
        public string? OpenaiApiUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether chess-style Elo is enabled.
        /// </summary>
        public bool? ChessStyleEloEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether real-time Elo updates are enabled.
        /// </summary>
        public bool? RealTimeEloUpdates { get; set; }
    }

    /// <summary>
    /// Represents Elo configuration settings for admin.
    /// </summary>
    public class AdminEloConfigResponse
    {
        /// <summary>
        /// Gets or sets the Elo K-factor.
        /// </summary>
        public int? EloKFactor { get; set; }

        /// <summary>
        /// Gets or sets the multi-transcriber threshold.
        /// </summary>
        public int? MultiTranscriberThreshold { get; set; }
    }
}
namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class GetAdminConfigResponse
    {
        public AdminWorkflowConfigResponse? WorkflowConfig { get; set; }
        public AdminOpenaiConfigResponse? OpenaiConfig { get; set; }
        public AdminAccessConfigResponse? AccessConfig { get; set; }
        public AdminDialectConfigResponse? DialectConfig { get; set; }
        public AdminQualityConfigResponse? QualityConfig { get; set; }
        public AdminContextAudioConfigResponse? ContextAudioConfig { get; set; }
        public AdminIntegrationConfigResponse? IntegrationConfig { get; set; }
    }

    public class AdminWorkflowConfigResponse
    {
        public string? AutoSaveInterval { get; set; }
        public int? JobTimeoutHours { get; set; }
        public int? MaxDraftVersions { get; set; }
        public int? ConcurrentSessionLimit { get; set; }
        public int? DefaultTranscribersPerJob { get; set; }
    }

    public class AdminOpenaiConfigResponse
    {
        public bool? Enabled { get; set; }
        public string? Model { get; set; }
        public int? SimilarityThreshold { get; set; }
        public int? ApiTimeout { get; set; }
        public int? MaxRetries { get; set; }
        public bool? FallbackToHuman { get; set; }
    }

    public class AdminAccessConfigResponse
    {
        public bool? OpenAccessEnabled { get; set; }
        public bool? EloBasedJobClaiming { get; set; }
        public string? RemoveJobDifficulty { get; set; }
        public bool? ChessStyleElo { get; set; }
    }

    public class AdminDialectConfigResponse
    {
        public List<string>? SupportedLanguages { get; set; }
        public List<string>? SupportedVariants { get; set; }
        public bool? ExtensibleForOtherLanguages { get; set; }
        public bool? DefaultSpellCheck { get; set; }
        public bool? EnableCustomDictionaries { get; set; }
    }

    public class AdminQualityConfigResponse
    {
        public bool? EnableAutoQualityCheck { get; set; }
        public float? MinQualityScoreForSubmission { get; set; }
        public bool? EnableDialectValidation { get; set; }
        public bool? OpenaiBasedQualityAssessment { get; set; }
        public bool? TiebreakerEnabled { get; set; }
        public bool? EloBasedQualityAssessment { get; set; }
    }

    public class AdminContextAudioConfigResponse
    {
        public bool? Enabled { get; set; }
        public string? DefaultContextWindow { get; set; }
        public string? MaxConcatenatedDuration { get; set; }
        public bool? SeamlessTransitions { get; set; }
        public List<string>? SupportedFormats { get; set; }
        public int? ContextCacheExpiryHours { get; set; }
        public bool? EnableVolumeNormalization { get; set; }
        public int? MaxContextRequestsPerJob { get; set; }
    }

    public class AdminIntegrationConfigResponse
    {
        public string? UserManagementApiUrl { get; set; }
        public string? QaServiceApiUrl { get; set; }
        public string? WorkflowEngineApiUrl { get; set; }
        public string? OpenaiApiUrl { get; set; }
        public bool? ChessStyleEloEnabled { get; set; }
        public bool? RealTimeEloUpdates { get; set; }
    }

    public class AdminEloConfigResponse
    {
        public int? EloKFactor { get; set; }
        public int? MultiTranscriberThreshold { get; set; }
    }
}

namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class UpdateAdminConfigRequest
    {
        public AdminWorkflowConfigRequest? WorkflowConfig { get; set; }
        public AdminEloConfigRequest? EloConfig { get; set; }
        public AdminDialectConfigRequest? DialectConfig { get; set; }
        public AdminQualityConfigRequest? QualityConfig { get; set; }
    }

    public class AdminWorkflowConfigRequest
    {
        public string? AutoSaveInterval { get; set; }
        public int? JobTimeoutHours { get; set; }
        public int? ConcurrentSessionLimit { get; set; }
    }

    public class AdminEloConfigRequest
    {
        public int? EloKFactor { get; set; }
        public int? MultiTranscriberThreshold { get; set; }
    }

    public class AdminDialectConfigRequest
    {
        public List<string>? SupportedVariants { get; set; }
        public bool? EnableCustomDictionaries { get; set; }
    }

    public class AdminQualityConfigRequest
    {
        public float? MinQualityScoreForSubmission { get; set; }
        public bool? EloBasedQualityAssessment { get; set; }
    }
}

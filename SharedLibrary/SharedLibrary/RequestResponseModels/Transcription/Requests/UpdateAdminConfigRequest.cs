namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to update admin configuration settings.
    /// </summary>
    public class UpdateAdminConfigRequest
    {
        /// <summary>
        /// Gets or sets the workflow configuration to update.
        /// </summary>
        public AdminWorkflowConfigRequest? WorkflowConfig { get; set; }

        /// <summary>
        /// Gets or sets the Elo configuration to update.
        /// </summary>
        public AdminEloConfigRequest? EloConfig { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration to update.
        /// </summary>
        public AdminDialectConfigRequest? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets the quality configuration to update.
        /// </summary>
        public AdminQualityConfigRequest? QualityConfig { get; set; }
    }

    /// <summary>
    /// Represents workflow configuration settings for admin update.
    /// </summary>
    public class AdminWorkflowConfigRequest
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
        /// Gets or sets the concurrent session limit.
        /// </summary>
        public int? ConcurrentSessionLimit { get; set; }
    }

    /// <summary>
    /// Represents Elo configuration settings for admin update.
    /// </summary>
    public class AdminEloConfigRequest
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

    /// <summary>
    /// Represents dialect configuration settings for admin update.
    /// </summary>
    public class AdminDialectConfigRequest
    {
        /// <summary>
        /// Gets or sets the supported variants.
        /// </summary>
        public List<string>? SupportedVariants { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether custom dictionaries are enabled.
        /// </summary>
        public bool? EnableCustomDictionaries { get; set; }
    }

    /// <summary>
    /// Represents quality configuration settings for admin update.
    /// </summary>
    public class AdminQualityConfigRequest
    {
        /// <summary>
        /// Gets or sets the minimum quality score required for submission.
        /// </summary>
        public float? MinQualityScoreForSubmission { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Elo-based quality assessment is enabled.
        /// </summary>
        public bool? EloBasedQualityAssessment { get; set; }
    }
}
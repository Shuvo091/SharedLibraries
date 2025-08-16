namespace SharedLibrary.Contracts.Transcription.Models
{
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
}
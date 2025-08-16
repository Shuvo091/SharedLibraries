namespace SharedLibrary.Contracts.Transcription.Models
{
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
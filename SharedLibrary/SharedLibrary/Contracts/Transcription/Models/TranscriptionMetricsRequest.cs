namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents metrics for a completed transcription.
    /// </summary>
    public class TranscriptionMetricsRequest
    {
        /// <summary>
        /// Gets or sets the words per minute rate.
        /// </summary>
        public double? WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets the confidence level of the transcription.
        /// </summary>
        public double? ConfidenceLevel { get; set; }

        /// <summary>
        /// Gets or sets the number of revisions made.
        /// </summary>
        public int? RevisionsCount { get; set; }
    }
}
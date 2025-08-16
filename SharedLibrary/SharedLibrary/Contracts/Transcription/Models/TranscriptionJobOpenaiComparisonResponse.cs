namespace SharedLibrary.Contracts.Transcription.Models
{
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
}
namespace SharedLibrary.Contracts.Transcription.Models
{
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
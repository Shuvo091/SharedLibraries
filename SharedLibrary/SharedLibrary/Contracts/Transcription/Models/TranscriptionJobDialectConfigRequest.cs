namespace SharedLibrary.Contracts.Transcription.Models
{
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
}
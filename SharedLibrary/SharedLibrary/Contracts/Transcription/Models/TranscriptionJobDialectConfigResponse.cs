namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the dialect configuration for a transcription job.
    /// </summary>
    public class TranscriptionJobDialectConfigResponse
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
    }
}
namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the dialect configuration for an available job.
    /// </summary>
    public class AvailableJobDialectConfigResponse
    {
        /// <summary>
        /// Gets or sets the language of the dialect.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// Gets or sets the variant of the dialect.
        /// </summary>
        public string? Variant { get; set; }
    }
}
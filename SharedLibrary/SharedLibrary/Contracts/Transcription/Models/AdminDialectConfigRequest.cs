namespace SharedLibrary.Contracts.Transcription.Models
{
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
}
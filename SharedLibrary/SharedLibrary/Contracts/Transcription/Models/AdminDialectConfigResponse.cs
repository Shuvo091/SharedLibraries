namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents dialect configuration settings for admin.
    /// </summary>
    public class AdminDialectConfigResponse
    {
        /// <summary>
        /// Gets or sets the supported languages.
        /// </summary>
        public List<string>? SupportedLanguages { get; set; }

        /// <summary>
        /// Gets or sets the supported variants.
        /// </summary>
        public List<string>? SupportedVariants { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether extensibility for other languages is enabled.
        /// </summary>
        public bool? ExtensibleForOtherLanguages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether default spell check is enabled.
        /// </summary>
        public bool? DefaultSpellCheck { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether custom dictionaries are enabled.
        /// </summary>
        public bool? EnableCustomDictionaries { get; set; }
    }
}
namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents context audio configuration settings for admin.
    /// </summary>
    public class AdminContextAudioConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether context audio is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the default context window.
        /// </summary>
        public string? DefaultContextWindow { get; set; }

        /// <summary>
        /// Gets or sets the maximum concatenated duration.
        /// </summary>
        public string? MaxConcatenatedDuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether seamless transitions are enabled.
        /// </summary>
        public bool? SeamlessTransitions { get; set; }

        /// <summary>
        /// Gets or sets the supported audio formats.
        /// </summary>
        public List<string>? SupportedFormats { get; set; }

        /// <summary>
        /// Gets or sets the context cache expiry in hours.
        /// </summary>
        public int? ContextCacheExpiryHours { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether volume normalization is enabled.
        /// </summary>
        public bool? EnableVolumeNormalization { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of context requests per job.
        /// </summary>
        public int? MaxContextRequestsPerJob { get; set; }
    }
}
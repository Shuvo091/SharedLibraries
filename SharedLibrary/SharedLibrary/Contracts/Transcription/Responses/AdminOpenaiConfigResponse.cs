namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents OpenAI configuration settings for admin.
    /// </summary>
    public class AdminOpenaiConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether OpenAI is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI model.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// Gets or sets the similarity threshold for OpenAI.
        /// </summary>
        public int? SimilarityThreshold { get; set; }

        /// <summary>
        /// Gets or sets the API timeout for OpenAI.
        /// </summary>
        public int? ApiTimeout { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of retries for OpenAI.
        /// </summary>
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to fallback to human.
        /// </summary>
        public bool? FallbackToHuman { get; set; }
    }
}
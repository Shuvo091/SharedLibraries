namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents integration configuration settings for admin.
    /// </summary>
    public class AdminIntegrationConfigResponse
    {
        /// <summary>
        /// Gets or sets the user management API URL.
        /// </summary>
        public string? UserManagementApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the QA service API URL.
        /// </summary>
        public string? QaServiceApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the workflow engine API URL.
        /// </summary>
        public string? WorkflowEngineApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI API URL.
        /// </summary>
        public string? OpenaiApiUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether chess-style Elo is enabled.
        /// </summary>
        public bool? ChessStyleEloEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether real-time Elo updates are enabled.
        /// </summary>
        public bool? RealTimeEloUpdates { get; set; }
    }
}
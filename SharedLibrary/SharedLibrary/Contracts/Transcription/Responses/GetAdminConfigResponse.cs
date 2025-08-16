using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing admin configuration settings.
    /// </summary>
    public class GetAdminConfigResponse
    {
        /// <summary>
        /// Gets or sets the workflow configuration.
        /// </summary>
        public AdminWorkflowConfigResponse? WorkflowConfig { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI configuration.
        /// </summary>
        public AdminOpenaiConfigResponse? OpenaiConfig { get; set; }

        /// <summary>
        /// Gets or sets the access configuration.
        /// </summary>
        public AdminAccessConfigResponse? AccessConfig { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration.
        /// </summary>
        public AdminDialectConfigResponse? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets the quality configuration.
        /// </summary>
        public AdminQualityConfigResponse? QualityConfig { get; set; }

        /// <summary>
        /// Gets or sets the context audio configuration.
        /// </summary>
        public AdminContextAudioConfigResponse? ContextAudioConfig { get; set; }

        /// <summary>
        /// Gets or sets the integration configuration.
        /// </summary>
        public AdminIntegrationConfigResponse? IntegrationConfig { get; set; }

        /// <summary>
        /// Gets or sets the elo configuration.
        /// </summary>
        public AdminEloConfigResponse? EloConfig { get; set; }
    }
}
using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to update admin configuration settings.
    /// </summary>
    public class UpdateAdminConfigRequest
    {
        /// <summary>
        /// Gets or sets the workflow configuration to update.
        /// </summary>
        public AdminWorkflowConfigRequest? WorkflowConfig { get; set; }

        /// <summary>
        /// Gets or sets the Elo configuration to update.
        /// </summary>
        public AdminEloConfigRequest? EloConfig { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration to update.
        /// </summary>
        public AdminDialectConfigRequest? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets the quality configuration to update.
        /// </summary>
        public AdminQualityConfigRequest? QualityConfig { get; set; }
    }
}
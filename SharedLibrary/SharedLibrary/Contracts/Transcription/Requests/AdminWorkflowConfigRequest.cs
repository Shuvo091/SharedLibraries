namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents workflow configuration settings for admin update.
    /// </summary>
    public class AdminWorkflowConfigRequest
    {
        /// <summary>
        /// Gets or sets the auto-save interval.
        /// </summary>
        public string? AutoSaveInterval { get; set; }

        /// <summary>
        /// Gets or sets the job timeout in hours.
        /// </summary>
        public int? JobTimeoutHours { get; set; }

        /// <summary>
        /// Gets or sets the concurrent session limit.
        /// </summary>
        public int? ConcurrentSessionLimit { get; set; }
    }
}
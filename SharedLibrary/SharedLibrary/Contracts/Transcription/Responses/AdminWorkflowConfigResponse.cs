namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents workflow configuration settings for admin.
    /// </summary>
    public class AdminWorkflowConfigResponse
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
        /// Gets or sets the maximum number of draft versions.
        /// </summary>
        public int? MaxDraftVersions { get; set; }

        /// <summary>
        /// Gets or sets the concurrent session limit.
        /// </summary>
        public int? ConcurrentSessionLimit { get; set; }

        /// <summary>
        /// Gets or sets the default number of transcribers per job.
        /// </summary>
        public int? DefaultTranscribersPerJob { get; set; }
    }
}
namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the workflow decision for a job.
    /// </summary>
    public class JobStateWorkflowDecisionResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the job is ready for comparison.
        /// </summary>
        public bool? ReadyForComparison { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a professional bypass is required.
        /// </summary>
        public bool? RequiresProfessionalBypass { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a tiebreaker is required.
        /// </summary>
        public bool? RequiresTiebreaker { get; set; }

        /// <summary>
        /// Gets or sets the suggested action for the job.
        /// </summary>
        public string? SuggestedAction { get; set; }

        /// <summary>
        /// Gets or sets the estimated ready time for the job.
        /// </summary>
        public DateTime? EstimatedReadyTime { get; set; }
    }
}
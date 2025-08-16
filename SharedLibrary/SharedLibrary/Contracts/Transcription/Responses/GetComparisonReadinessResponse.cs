namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response indicating readiness for transcription comparison.
    /// </summary>
    public class GetComparisonReadinessResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is ready for comparison.
        /// </summary>
        public bool? ComparisonReady { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions completed.
        /// </summary>
        public int? TranscriptionsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions needed.
        /// </summary>
        public int? TranscriptionsNeeded { get; set; }

        /// <summary>
        /// Gets or sets the list of transcriptions for comparison readiness.
        /// </summary>
        public List<ComparisonReadinessTranscriptionResponse>? Transcriptions { get; set; } = new ();

        /// <summary>
        /// Gets or sets the reason for waiting, if any.
        /// </summary>
        public string? WaitingFor { get; set; }

        /// <summary>
        /// Gets or sets the estimated readiness date and time.
        /// </summary>
        public DateTime? EstimatedReadiness { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether professional bypass is enabled.
        /// </summary>
        public bool? ProfessionalBypass { get; set; }

        /// <summary>
        /// Gets or sets the professional transcriber identifier, if any.
        /// </summary>
        public Guid? ProfessionalTranscriber { get; set; }

        /// <summary>
        /// Gets or sets the next action to be taken.
        /// </summary>
        public string? NextAction { get; set; }
    }
}
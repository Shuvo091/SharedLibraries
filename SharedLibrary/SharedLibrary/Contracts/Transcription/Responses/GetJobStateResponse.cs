namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing the state of a transcription job.
    /// </summary>
    public class GetJobStateResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the current state of the job.
        /// </summary>
        public string? CurrentState { get; set; }

        /// <summary>
        /// Gets or sets the transcription progress for the job.
        /// </summary>
        public JobStateTranscriptionProgressResponse? TranscriptionProgress { get; set; }

        /// <summary>
        /// Gets or sets the workflow decision for the job.
        /// </summary>
        public JobStateWorkflowDecisionResponse? WorkflowDecision { get; set; }

        /// <summary>
        /// Gets or sets the metadata for the job.
        /// </summary>
        public JobStateJobMetadataResponse? Metadata { get; set; }
    }
}
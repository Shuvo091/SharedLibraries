namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response after completing a transcription job.
    /// </summary>
    public class CreateTranscriptionCompleteResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the completion was acknowledged.
        /// </summary>
        public bool? Acknowledged { get; set; }

        /// <summary>
        /// Gets or sets the current workflow state.
        /// </summary>
        public string? WorkflowState { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions received.
        /// </summary>
        public int? TranscriptionsReceived { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions needed.
        /// </summary>
        public int? TranscriptionsNeeded { get; set; }

        /// <summary>
        /// Gets or sets the next action to be taken in the workflow.
        /// </summary>
        public string? NextAction { get; set; }

        /// <summary>
        /// Gets or sets the workflow steps for the transcription completion.
        /// </summary>
        public List<TranscriptionCompleteWorkflowStepResponse>? WorkflowSteps { get; set; }

        /// <summary>
        /// Gets or sets the estimated completion date and time.
        /// </summary>
        public DateTime? EstimatedCompletion { get; set; }
    }
}
namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents a workflow step in the transcription completion process.
    /// </summary>
    public class TranscriptionCompleteWorkflowStepResponse
    {
        /// <summary>
        /// Gets or sets the step number.
        /// </summary>
        public int? Step { get; set; }

        /// <summary>
        /// Gets or sets the action for this workflow step.
        /// </summary>
        public string? Action { get; set; }

        /// <summary>
        /// Gets or sets the status of this workflow step.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the trigger condition for this workflow step.
        /// </summary>
        public string? TriggerCondition { get; set; }
    }
}
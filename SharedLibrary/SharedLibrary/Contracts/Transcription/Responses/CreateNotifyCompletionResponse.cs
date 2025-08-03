namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response after notifying completion of a transcription job.
    /// </summary>
    public class CreateNotifyCompletionResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the notification was acknowledged.
        /// </summary>
        public bool? Acknowledged { get; set; }

        /// <summary>
        /// Gets or sets the workflow action to be taken next.
        /// </summary>
        public string? WorkflowAction { get; set; }
    }
}
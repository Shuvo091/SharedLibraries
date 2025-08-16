namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to notify completion of a transcription job.
    /// </summary>
    public class CreateNotifyCompletionRequest
    {
        /// <summary>
        /// Gets or sets the event type.
        /// </summary>
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the event data for completion notification.
        /// </summary>
        public NotifyCompletionEventDataRequest? EventData { get; set; }

        /// <summary>
        /// Gets or sets the metadata for completion notification.
        /// </summary>
        public NotifyCompletionMetadataRequest? Metadata { get; set; }
    }
}
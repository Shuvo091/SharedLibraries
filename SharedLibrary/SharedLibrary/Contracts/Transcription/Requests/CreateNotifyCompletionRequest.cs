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

    /// <summary>
    /// Represents event data for completion notification.
    /// </summary>
    public class NotifyCompletionEventDataRequest
    {
        /// <summary>
        /// Gets or sets the transcriber identifier.
        /// </summary>
        public Guid? TranscriberId { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence number.
        /// </summary>
        public int? TranscriptionSequence { get; set; }

        /// <summary>
        /// Gets or sets the completion date and time.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transcriber is a professional.
        /// </summary>
        public bool? IsProfessional { get; set; }
    }

    /// <summary>
    /// Represents metadata for completion notification.
    /// </summary>
    public class NotifyCompletionMetadataRequest
    {
        /// <summary>
        /// Gets or sets the number of transcribers completed.
        /// </summary>
        public int? TranscribersCompleted { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers needed.
        /// </summary>
        public int? TranscribersNeeded { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is ready for comparison.
        /// </summary>
        public bool? ReadyForComparison { get; set; }
    }
}
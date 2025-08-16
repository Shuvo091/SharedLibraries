namespace SharedLibrary.Contracts.Transcription.Models
{
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
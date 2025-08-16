namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents the completion status of a transcription job.
    /// </summary>
    public class JobCompletionStatusRequest
    {
        /// <summary>
        /// Gets or sets the number of transcriptions completed.
        /// </summary>
        public int? TranscriptionsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions needed.
        /// </summary>
        public int? TranscriptionsNeeded { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all transcriptions are complete.
        /// </summary>
        public bool? AllTranscriptionsComplete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is ready for comparison.
        /// </summary>
        public bool? ReadyForComparison { get; set; }
    }
}
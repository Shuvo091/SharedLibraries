namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the transcription progress for a job.
    /// </summary>
    public class JobStateTranscriptionProgressResponse
    {
        /// <summary>
        /// Gets or sets the number of transcriptions needed.
        /// </summary>
        public int? Needed { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions completed.
        /// </summary>
        public int? Completed { get; set; }

        /// <summary>
        /// Gets or sets the number of transcriptions in progress.
        /// </summary>
        public int? InProgress { get; set; }

        /// <summary>
        /// Gets or sets the list of completed transcriptions.
        /// </summary>
        public List<JobStateCompletedTranscriptionResponse>? CompletedTranscriptions { get; set; }
    }
}
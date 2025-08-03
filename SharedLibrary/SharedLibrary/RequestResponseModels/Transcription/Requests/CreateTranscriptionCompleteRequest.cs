namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to mark a transcription job as complete.
    /// </summary>
    public class CreateTranscriptionCompleteRequest
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the transcription identifier.
        /// </summary>
        public Guid? TranscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the transcriber identifier.
        /// </summary>
        public Guid? TranscriberId { get; set; }

        /// <summary>
        /// Gets or sets the transcription data.
        /// </summary>
        public TranscriptionDataRequest? TranscriptionData { get; set; }

        /// <summary>
        /// Gets or sets the job completion status.
        /// </summary>
        public JobCompletionStatusRequest? JobCompletionStatus { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the completed transcription.
        /// </summary>
        public TranscriptionCompleteAudioMetadataRequest? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the transcription metrics.
        /// </summary>
        public TranscriptionMetricsRequest? TranscriptionMetrics { get; set; }
    }

    /// <summary>
    /// Represents the data for a completed transcription.
    /// </summary>
    public class TranscriptionDataRequest
    {
        /// <summary>
        /// Gets or sets the content of the transcription.
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence number.
        /// </summary>
        public int? TranscriptionSequence { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transcription was submitted.
        /// </summary>
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Gets or sets the time spent on the transcription.
        /// </summary>
        public string? TimeSpent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transcriber is a professional.
        /// </summary>
        public bool? IsProfessional { get; set; }
    }

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

    /// <summary>
    /// Represents audio metadata for a completed transcription.
    /// </summary>
    public class TranscriptionCompleteAudioMetadataRequest
    {
        /// <summary>
        /// Gets or sets the segment identifier.
        /// </summary>
        public string? SegmentId { get; set; }

        /// <summary>
        /// Gets or sets the dialect of the audio.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets the duration of the audio segment.
        /// </summary>
        public string? Duration { get; set; }
    }

    /// <summary>
    /// Represents metrics for a completed transcription.
    /// </summary>
    public class TranscriptionMetricsRequest
    {
        /// <summary>
        /// Gets or sets the words per minute rate.
        /// </summary>
        public double? WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets the confidence level of the transcription.
        /// </summary>
        public double? ConfidenceLevel { get; set; }

        /// <summary>
        /// Gets or sets the number of revisions made.
        /// </summary>
        public int? RevisionsCount { get; set; }
    }
}
namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class CreateTranscriptionCompleteRequest
    {
        public Guid? JobId { get; set; }
        public Guid? TranscriptionId { get; set; }
        public Guid? TranscriberId { get; set; }
        public TranscriptionDataRequest? TranscriptionData { get; set; }
        public JobCompletionStatusRequest? JobCompletionStatus { get; set; }
        public TranscriptionCompleteAudioMetadataRequest? AudioMetadata { get; set; }
        public TranscriptionMetricsRequest? TranscriptionMetrics { get; set; }
    }

    public class TranscriptionDataRequest
    {
        public string? Content { get; set; }
        public int? TranscriptionSequence { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public string? TimeSpent { get; set; }
        public bool? IsProfessional { get; set; }
    }

    public class JobCompletionStatusRequest
    {
        public int? TranscriptionsCompleted { get; set; }
        public int? TranscriptionsNeeded { get; set; }
        public bool? AllTranscriptionsComplete { get; set; }
        public bool? ReadyForComparison { get; set; }
    }

    public class TranscriptionCompleteAudioMetadataRequest
    {
        public string? SegmentId { get; set; }
        public string? Dialect { get; set; }
        public string? Duration { get; set; }
    }

    public class TranscriptionMetricsRequest
    {
        public double? WordsPerMinute { get; set; }
        public double? ConfidenceLevel { get; set; }
        public int? RevisionsCount { get; set; }
    }
}

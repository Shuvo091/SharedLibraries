namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class CreateNotifyCompletionRequest
    {
        public string? EventType { get; set; }
        public Guid? JobId { get; set; }
        public NotifyCompletionEventDataRequest? EventData { get; set; }
        public NotifyCompletionMetadataRequest? Metadata { get; set; }
    }

    public class NotifyCompletionEventDataRequest
    {
        public Guid? TranscriberId { get; set; }
        public int? TranscriptionSequence { get; set; }
        public DateTime? CompletedAt { get; set; }
        public bool? IsProfessional { get; set; }
    }

    public class NotifyCompletionMetadataRequest
    {
        public int? TranscribersCompleted { get; set; }
        public int? TranscribersNeeded { get; set; }
        public bool? ReadyForComparison { get; set; }
    }
}

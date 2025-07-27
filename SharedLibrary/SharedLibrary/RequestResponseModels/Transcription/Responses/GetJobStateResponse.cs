namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class GetJobStateResponse
    {
        public Guid? JobId { get; set; }
        public string? CurrentState { get; set; }
        public JobStateTranscriptionProgressResponse? TranscriptionProgress { get; set; }
        public JobStateWorkflowDecisionResponse? WorkflowDecision { get; set; }
        public JobStateJobMetadataResponse? Metadata { get; set; }
    }

    public class JobStateTranscriptionProgressResponse
    {
        public int? Needed { get; set; }
        public int? Completed { get; set; }
        public int? InProgress { get; set; }
        public List<JobStateCompletedTranscriptionResponse>? CompletedTranscriptions { get; set; }
    }

    public class JobStateWorkflowDecisionResponse
    {
        public bool? ReadyForComparison { get; set; }
        public bool? RequiresProfessionalBypass { get; set; }
        public bool? RequiresTiebreaker { get; set; }
        public string? SuggestedAction { get; set; }
        public DateTime? EstimatedReadyTime { get; set; }
    }

    public class JobStateJobMetadataResponse
    {
        public DateTime? JobCreatedAt { get; set; }
        public DateTime? Deadline { get; set; }
        public string? Dialect { get; set; }
    }

    public class JobStateCompletedTranscriptionResponse
    {
        public Guid? TranscriptionId { get; set; }
        public Guid? TranscriberId { get; set; }
        public DateTime? CompletedAt { get; set; }
        public bool? IsProfessional { get; set; }
    }
}

namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class GetComparisonReadinessResponse
    {
        public Guid? JobId { get; set; }
        public bool? ComparisonReady { get; set; }
        public int? TranscriptionsCompleted { get; set; }
        public int? TranscriptionsNeeded { get; set; }
        public List<ComparisonReadinessTranscriptionResponse>? Transcriptions { get; set; } = new();
        public string? WaitingFor { get; set; }
        public DateTime? EstimatedReadiness { get; set; }
        public bool? ProfessionalBypass { get; set; }
        public string? ProfessionalTranscriber { get; set; }
        public string? NextAction { get; set; }
    }

    public class ComparisonReadinessTranscriptionResponse
    {
        public string? TranscriptionId { get; set; }
        public string? TranscriberId { get; set; }
        public int? Sequence { get; set; }
        public DateTime? CompletedAt { get; set; }
        public bool? IsProfessional { get; set; }
    }
}

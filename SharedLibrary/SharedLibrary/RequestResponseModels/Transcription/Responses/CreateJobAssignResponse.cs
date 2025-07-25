namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class CreateJobAssignResponse
    {
        public Guid? JobId { get; set; }
        public string? Status { get; set; }
        public DateTime? AssignedAt { get; set; }
        public DateTime? Deadline { get; set; }
        public int? TranscriptionSequence { get; set; }
        public Guid? SessionId { get; set; }
        public string? WebsocketUrl { get; set; }
        public JobAssignOpenaiComparisonResponse? OpenAiComparison { get; set; }

        public string? Error { get; set; }
        public string? Message { get; set; }
        public int? TranscribersNeeded { get; set; }
        public int? CurrentTranscribers { get; set; }
    }

    public class JobAssignOpenaiComparisonResponse
    {
        public bool? Enabled { get; set; }
        public int? SimilarityThreshold { get; set; }
        public bool? AwaitingSecondTranscriber { get; set; }
    }
}

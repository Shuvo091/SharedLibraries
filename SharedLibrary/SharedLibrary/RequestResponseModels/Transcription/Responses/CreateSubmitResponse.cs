namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class CreateSubmitResponse
    {
        public Guid SubmissionId { get; set; }
        public string? Status { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public string? NextStep { get; set; }
        public string? TurnaroundTime { get; set; }
        public CreateSubmitOpenaiComparisonResponse? OpenaiComparison { get; set; }
    }

    public class CreateSubmitOpenaiComparisonResponse
    {
        public string? Status { get; set; }
        public bool? ReadyForComparison { get; set; }
        public int? TranscriptionSequence { get; set; }
    }
}

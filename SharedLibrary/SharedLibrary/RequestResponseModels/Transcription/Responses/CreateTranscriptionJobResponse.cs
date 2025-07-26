namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class CreateTranscriptionJobResponse
    {
        public Guid JobId { get; set; }
        public string? Status { get; set; }
        public int? TranscribersNeeded { get; set; }
        public int? TranscribersAssigned { get; set; }
        public DateTime? Deadline { get; set; }
        public string? JobUri { get; set; }
        public CreateTranscriptionJobDialectConfigResponse? DialectConfig { get; set; }
        public bool? OpenAccessEnabled { get; set; }
    }

    public class CreateTranscriptionJobDialectConfigResponse
    {
        public string? Language { get; set; }
        public string? Variant { get; set; }
    }
}

namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class GetTranscriptionJobResponse
    {
        public Guid JobId { get; set; }
        public string? Status { get; set; }
        public string? AudioUri { get; set; }
        public TranscriptionJobAudioMetadataResponse? AudioMetadata { get; set; }
        public List<TranscriptionJobTranscriberResponse>? Transcribers { get; set; }
        public int? TranscribersNeeded { get; set; }
        public bool? ProfessionalOnly { get; set; }
        public bool? BypassQaComparison { get; set; }
        public DateTime? Deadline { get; set; }
        public int? ProgressPercentage { get; set; }
        public TranscriptionJobOpenaiComparisonResponse? OpenaiComparison { get; set; }
        public TranscriptionJobCurrentDraftResponse? CurrentDraft { get; set; }
        public TranscriptionJobDialectConfigResponse? DialectConfig { get; set; }
    }

    public class TranscriptionJobAudioMetadataResponse
    {
        public string? Duration { get; set; }
        public string? Dialect { get; set; }
        public string? FileSize { get; set; }
        public string? Format { get; set; }
    }

    public class TranscriptionJobTranscriberResponse
    {
        public Guid? UserId { get; set; }
        public int? Sequence { get; set; }
        public string? Status { get; set; }
        public string? Role { get; set; }
        public DateTime? ClaimedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }

    public class TranscriptionJobOpenaiComparisonResponse
    {
        public string? Status { get; set; }
        public bool? ReadyForComparison { get; set; }
        public bool? RequiresThirdTranscriber { get; set; }
    }

    public class TranscriptionJobCurrentDraftResponse
    {
        public string? Text { get; set; }
        public int? WordCount { get; set; }
        public DateTime? LastSaved { get; set; }
        public int? Version { get; set; }
    }

    public class TranscriptionJobDialectConfigResponse
    {
        public string? Language { get; set; }
        public string? Variant { get; set; }
        public bool? SpellCheckEnabled { get; set; }
    }
}

namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class CreateTranscriptionJobRequest
    {
        public string? AudioUri { get; set; }
        public TranscriptionJobAudioMetadataRequest? AudioMetadata { get; set; }
        public int? TranscribersNeeded { get; set; }
        public DateTime? Deadline { get; set; }
        public string? WorkflowStrategy { get; set; }
        public TranscriptionJobDialectConfigRequest? DialectConfig { get; set; }
        public TranscriptionJobOpenaiConfigRequest? OpenaiConfig { get; set; }
    }

    public class TranscriptionJobAudioMetadataRequest
    {
        public string? Duration { get; set; }
        public string? Dialect { get; set; }
        public float? QualityScore { get; set; }
        public string? EstimatedDifficulty { get; set; }
    }

    public class TranscriptionJobDialectConfigRequest
    {
        public string? Language { get; set; }
        public string? Variant { get; set; }
        public bool? SpellCheckEnabled { get; set; }
        public string? CustomDictionary { get; set; }
    }

    public class TranscriptionJobOpenaiConfigRequest
    {
        public int? SimilarityThreshold { get; set; }
        public bool? RequiresThirdTranscriber { get; set; }
        public string? LanguageContext { get; set; }
    }
}

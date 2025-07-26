namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class CreateSubmitRequest
    {
        public string? FinalText { get; set; }
        public string? QualityNotes { get; set; }
        public int? TimeSpent { get; set; }
        public int? ConfidenceScore { get; set; }
        public int? DialectConsistency { get; set; }
        public SubmitTranscriptionMetadataRequest? TranscriptionMetadata { get; set; }
    }

    public class SubmitTranscriptionMetadataRequest
    {
        public string? ChunkingStrategy { get; set; }
        public bool? NoiseReductionApplied { get; set; }
        public List<float>? PlaybackSpeedUsed { get; set; }
        public int? TimestampCount { get; set; }
        public int? SpellingCorrections { get; set; }
    }
}

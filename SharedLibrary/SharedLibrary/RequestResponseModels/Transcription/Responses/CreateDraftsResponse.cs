namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class CreateDraftsResponse
    {
        public Guid DraftId { get; set; }
        public int? Version { get; set; }
        public DateTime? SavedAt { get; set; }
        public int? WordCount { get; set; }
        public int? EstimatedCompletion { get; set; }
    }
}

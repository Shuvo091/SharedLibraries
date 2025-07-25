namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class CreateDraftsRequest
    {
        public string? Text { get; set; }
        public int? CursorPosition { get; set; }
        public string? SelectedText { get; set; }
        public List<DraftsTimestampsRequest>? Timestamps { get; set; }
        public int? Confidence { get; set; }
    }

    public class DraftsTimestampsRequest
    {
        public int? Position { get; set; }
        public string? Time { get; set; }
    }
}

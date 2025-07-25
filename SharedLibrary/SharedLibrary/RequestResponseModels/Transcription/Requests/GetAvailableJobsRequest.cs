namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class GetAvailableJobsRequest
    {
        public string? Dialect { get; set; }
        public int Limit { get; set; } = 50;
        public string SortBy { get; set; } = "deadline";
        public bool? NeedsTranscribers { get; set; }
    }
}

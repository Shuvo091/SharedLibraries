namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class GetClaimedJobsRequest
    {
        public string? Status { get; set; }
        public int? Limit { get; set; }
        public string? Dialect { get; set; }
    }
}

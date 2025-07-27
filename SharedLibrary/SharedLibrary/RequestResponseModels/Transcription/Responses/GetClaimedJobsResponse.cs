namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class GetClaimedJobsResponse
    {
        public List<ClaimedJobResponse>? ClaimedJobs { get; set; }
        public int? TotalClaimed { get; set; }
        public DateTime? QueryTimestamp { get; set; }
    }

    public class ClaimedJobResponse
    {
        public Guid? JobId { get; set; }
        public string? Status { get; set; }
        public ClaimedJobAudioMetadataResponse? AudioMetadata { get; set; }
        public DateTime? ClaimedAt { get; set; }
        public DateTime? Deadline { get; set; }
        public int? ProgressPercentage { get; set; }
        public DateTime? BookOutTimeout { get; set; }
    }

    public class ClaimedJobAudioMetadataResponse
    {
        public string? Duration { get; set; }
        public string? Dialect { get; set; }
    }
}

namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class GetAvailableJobsResponse
    {
        public List<AvailableJobResponse>? AvailableJobs { get; set; }
        public int? TotalAvailable { get; set; }
        public DateTime? QueryTimestamp { get; set; }
        public AvailableJobFiltersResponse? Filters { get; set; }
    }

    public class AvailableJobResponse
    {
        public Guid JobId { get; set; }
        public string? AudioUri { get; set; }
        public AvailableJobAudioMetadataResponse? AudioMetadata { get; set; }
        public int? TranscribersNeeded { get; set; }
        public int? TranscribersAssigned { get; set; }
        public DateTime? Deadline { get; set; }
        public string? Priority { get; set; }
        public string? WorkflowStrategy { get; set; }
        public int? BookOutTimeoutHours { get; set; }
        public AvailableJobDialectConfigResponse? DialectConfig { get; set; }
        public bool? OpenAccessEnabled { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

    public class AvailableJobFiltersResponse
    {
        public string? Dialect { get; set; }
        public bool? NeedsTranscribers { get; set; }
    }

    public class AvailableJobAudioMetadataResponse
    {
        public string? Duration { get; set; }
        public string? Dialect { get; set; }
        public string? FileSize { get; set; }
        public string? EstimatedDifficulty { get; set; }
    }

    public class AvailableJobDialectConfigResponse
    {
        public string? Language { get; set; }
        public string? Variant { get; set; }
    }
}

namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to get claimed transcription jobs.
    /// </summary>
    public class GetClaimedJobsRequest
    {
        /// <summary>
        /// Gets or sets the status filter for claimed jobs.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of jobs to return.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets the dialect filter for claimed jobs.
        /// </summary>
        public string? Dialect { get; set; }
    }
}
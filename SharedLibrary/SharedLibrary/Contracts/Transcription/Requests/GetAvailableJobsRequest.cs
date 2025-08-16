namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to get available transcription jobs.
    /// </summary>
    public class GetAvailableJobsRequest
    {
        /// <summary>
        /// Gets or sets the dialect filter for the jobs.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of jobs to return.
        /// </summary>
        public int Limit { get; set; } = 50;

        /// <summary>
        /// Gets or sets the field by which to sort the jobs.
        /// </summary>
        public string SortBy { get; set; } = "deadline";

        /// <summary>
        /// Gets or sets a value indicating whether only jobs needing transcribers should be returned.
        /// </summary>
        public bool? NeedsTranscribers { get; set; }
    }
}
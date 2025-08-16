using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing claimed transcription jobs.
    /// </summary>
    public class GetClaimedJobsResponse
    {
        /// <summary>
        /// Gets or sets the list of claimed jobs.
        /// </summary>
        public List<ClaimedJobResponse>? ClaimedJobs { get; set; }

        /// <summary>
        /// Gets or sets the total number of claimed jobs.
        /// </summary>
        public int? TotalClaimed { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the query was made.
        /// </summary>
        public DateTime? QueryTimestamp { get; set; }
    }
}
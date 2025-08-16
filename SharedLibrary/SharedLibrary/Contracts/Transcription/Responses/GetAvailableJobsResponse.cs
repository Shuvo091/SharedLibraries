using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing available transcription jobs.
    /// </summary>
    public class GetAvailableJobsResponse
    {
        /// <summary>
        /// Gets or sets the list of available jobs.
        /// </summary>
        public List<AvailableJobResponse>? AvailableJobs { get; set; }

        /// <summary>
        /// Gets or sets the total number of available jobs.
        /// </summary>
        public int? TotalAvailable { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the query was made.
        /// </summary>
        public DateTime? QueryTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the filters applied to the available jobs query.
        /// </summary>
        public AvailableJobFiltersResponse? Filters { get; set; }
    }
}
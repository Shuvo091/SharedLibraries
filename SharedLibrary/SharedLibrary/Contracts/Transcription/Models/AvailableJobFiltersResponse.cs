namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents filters applied to available jobs.
    /// </summary>
    public class AvailableJobFiltersResponse
    {
        /// <summary>
        /// Gets or sets the dialect filter.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether jobs need transcribers.
        /// </summary>
        public bool? NeedsTranscribers { get; set; }
    }
}
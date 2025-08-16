namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents audio metadata for a claimed job.
    /// </summary>
    public class ClaimedJobAudioMetadataResponse
    {
        /// <summary>
        /// Gets or sets the duration of the audio file.
        /// </summary>
        public string? Duration { get; set; }

        /// <summary>
        /// Gets or sets the dialect of the audio file.
        /// </summary>
        public string? Dialect { get; set; }
    }
}
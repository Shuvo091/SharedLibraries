namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents audio metadata for an available job.
    /// </summary>
    public class AvailableJobAudioMetadataResponse
    {
        /// <summary>
        /// Gets or sets the duration of the audio file.
        /// </summary>
        public string? Duration { get; set; }

        /// <summary>
        /// Gets or sets the dialect of the audio file.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets the file size of the audio file.
        /// </summary>
        public string? FileSize { get; set; }

        /// <summary>
        /// Gets or sets the estimated difficulty of the job.
        /// </summary>
        public string? EstimatedDifficulty { get; set; }
    }
}
namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents audio metadata for a transcription job.
    /// </summary>
    public class TranscriptionJobAudioMetadataResponse
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
        /// Gets or sets the format of the audio file.
        /// </summary>
        public string? Format { get; set; }
    }
}
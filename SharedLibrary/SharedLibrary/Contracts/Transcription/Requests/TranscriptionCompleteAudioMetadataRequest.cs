namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents audio metadata for a completed transcription.
    /// </summary>
    public class TranscriptionCompleteAudioMetadataRequest
    {
        /// <summary>
        /// Gets or sets the segment identifier.
        /// </summary>
        public string? SegmentId { get; set; }

        /// <summary>
        /// Gets or sets the dialect of the audio.
        /// </summary>
        public string? Dialect { get; set; }

        /// <summary>
        /// Gets or sets the duration of the audio segment.
        /// </summary>
        public string? Duration { get; set; }
    }
}
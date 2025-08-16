namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents metadata for a submitted transcription.
    /// </summary>
    public class SubmitTranscriptionMetadataRequest
    {
        /// <summary>
        /// Gets or sets the chunking strategy used.
        /// </summary>
        public string? ChunkingStrategy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether noise reduction was applied.
        /// </summary>
        public bool? NoiseReductionApplied { get; set; }

        /// <summary>
        /// Gets or sets the playback speeds used.
        /// </summary>
        public List<float>? PlaybackSpeedUsed { get; set; }

        /// <summary>
        /// Gets or sets the number of timestamps in the transcription.
        /// </summary>
        public int? TimestampCount { get; set; }

        /// <summary>
        /// Gets or sets the number of spelling corrections made.
        /// </summary>
        public int? SpellingCorrections { get; set; }
    }
}
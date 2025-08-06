namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to submit a completed transcription.
    /// </summary>
    public class CreateSubmitRequest
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets the final transcribed text.
        /// </summary>
        public string? FinalText { get; set; }

        /// <summary>
        /// Gets or sets the quality notes for the transcription.
        /// </summary>
        public string? QualityNotes { get; set; }

        /// <summary>
        /// Gets or sets the time spent on the transcription.
        /// </summary>
        public int? TimeSpent { get; set; }

        /// <summary>
        /// Gets or sets the confidence score for the transcription.
        /// </summary>
        public int? ConfidenceScore { get; set; }

        /// <summary>
        /// Gets or sets the dialect consistency score.
        /// </summary>
        public int? DialectConsistency { get; set; }

        /// <summary>
        /// Gets or sets the metadata for the transcription submission.
        /// </summary>
        public SubmitTranscriptionMetadataRequest? TranscriptionMetadata { get; set; }
    }

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
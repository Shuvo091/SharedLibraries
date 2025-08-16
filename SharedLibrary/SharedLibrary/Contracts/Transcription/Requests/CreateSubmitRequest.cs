namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to submit a completed transcription.
    /// </summary>
    public class CreateSubmitRequest
    {
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
}
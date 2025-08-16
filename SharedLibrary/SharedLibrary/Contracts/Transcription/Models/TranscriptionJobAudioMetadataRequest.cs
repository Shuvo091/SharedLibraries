namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents audio metadata for a transcription job.
    /// </summary>
    public class TranscriptionJobAudioMetadataRequest
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
        /// Gets or sets the quality score of the audio file.
        /// </summary>
        public float? QualityScore { get; set; }

        /// <summary>
        /// Gets or sets the estimated difficulty of the job.
        /// </summary>
        public string? EstimatedDifficulty { get; set; }
    }
}
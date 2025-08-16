namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents audio metadata for a transcription job.
    /// </summary>
    public class TranscriptionJobAudioContextMetadataRequest
    {
        /// <summary>
        /// Gets or sets audio context job id.
        /// </summary>
        public string? AudioContextJobId { get; set; }

        /// <summary>
        /// Gets or sets the chunk Id.
        /// </summary>
        public string? ChunkId { get; set; }
    }
}
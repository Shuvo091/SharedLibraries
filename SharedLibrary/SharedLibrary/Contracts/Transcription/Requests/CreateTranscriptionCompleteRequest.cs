using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to mark a transcription job as complete.
    /// </summary>
    public class CreateTranscriptionCompleteRequest
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the transcription identifier.
        /// </summary>
        public Guid? TranscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the transcriber identifier.
        /// </summary>
        public Guid? TranscriberId { get; set; }

        /// <summary>
        /// Gets or sets the transcription data.
        /// </summary>
        public TranscriptionDataRequest? TranscriptionData { get; set; }

        /// <summary>
        /// Gets or sets the job completion status.
        /// </summary>
        public JobCompletionStatusRequest? JobCompletionStatus { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the completed transcription.
        /// </summary>
        public TranscriptionCompleteAudioMetadataRequest? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the transcription metrics.
        /// </summary>
        public TranscriptionMetricsRequest? TranscriptionMetrics { get; set; }
    }
}
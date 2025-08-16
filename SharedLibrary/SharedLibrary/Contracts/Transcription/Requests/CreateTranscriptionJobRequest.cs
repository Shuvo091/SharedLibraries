using SharedLibrary.Contracts.Transcription.Models;

namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to create a new transcription job.
    /// </summary>
    public class CreateTranscriptionJobRequest
    {
        /// <summary>
        /// Gets or sets the URI of the audio file to be transcribed.
        /// </summary>
        public string? AudioUri { get; set; }

        /// <summary>
        /// Gets or sets the audio metadata for the job.
        /// </summary>
        public TranscriptionJobAudioMetadataRequest? AudioMetadata { get; set; }

        /// <summary>
        /// Gets or sets the audio context metadata for the job.
        /// </summary>
        public TranscriptionJobAudioContextMetadataRequest? AudioMetaContextdata { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers needed for the job.
        /// </summary>
        public int? TranscribersNeeded { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the workflow strategy for the job.
        /// </summary>
        public string? WorkflowStrategy { get; set; }

        /// <summary>
        /// Gets or sets the dialect configuration for the job.
        /// </summary>
        public TranscriptionJobDialectConfigRequest? DialectConfig { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI configuration for the job.
        /// </summary>
        public TranscriptionJobOpenaiConfigRequest? OpenaiConfig { get; set; }
    }
}
namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents a completed transcription for a job.
    /// </summary>
    public class JobStateCompletedTranscriptionResponse
    {
        /// <summary>
        /// Gets or sets the transcription identifier.
        /// </summary>
        public Guid? TranscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the transcriber identifier.
        /// </summary>
        public Guid? TranscriberId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transcription was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transcriber is a professional.
        /// </summary>
        public bool? IsProfessional { get; set; }
    }
}
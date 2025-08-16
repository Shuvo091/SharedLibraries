namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents a transcription in the comparison readiness response.
    /// </summary>
    public class ComparisonReadinessTranscriptionResponse
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
        /// Gets or sets the sequence number of the transcription.
        /// </summary>
        public int? Sequence { get; set; }

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
namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Gets the completed transcription response.
    /// </summary>
    public class GetTranscriptionResponse
    {
        /// <summary>
        /// Gets or sets the transcription ID.
        /// </summary>
        public Guid TranscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the job ID associated with the transcription.
        /// </summary>
        public Guid TranscriberId { get; set; }

        /// <summary>
        /// Gets or sets the transcriber role.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence.
        /// </summary>
        public int? Sequence { get; set; }

        /// <summary>
        /// Gets or sets the completed status of the transcription.
        /// </summary>
        public string? CompletedStatus { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transcription was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
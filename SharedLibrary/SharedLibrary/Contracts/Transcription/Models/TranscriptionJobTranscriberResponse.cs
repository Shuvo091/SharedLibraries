namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents a transcriber for a transcription job.
    /// </summary>
    public class TranscriptionJobTranscriberResponse
    {
        /// <summary>
        /// Gets or sets the user identifier of the transcriber.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets the sequence number of the transcriber.
        /// </summary>
        public int? Sequence { get; set; }

        /// <summary>
        /// Gets or sets the status of the transcriber.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the role of the transcriber.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was claimed by the transcriber.
        /// </summary>
        public DateTime? ClaimedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was completed by the transcriber.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
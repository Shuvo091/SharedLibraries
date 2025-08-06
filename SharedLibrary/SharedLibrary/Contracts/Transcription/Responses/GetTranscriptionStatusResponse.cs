namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response containing the transcription status for a job.
    /// </summary>
    public class GetTranscriptionStatusResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the job.
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// Gets or sets the total number of transcribers available.
        /// </summary>
        public int? TotalTranscribers { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers currently assigned to the job.
        /// </summary>
        public int? TargetTranscribers { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers who have completed their work.
        /// </summary>
        public bool? ReadyForComparison { get; set; }
    }
}

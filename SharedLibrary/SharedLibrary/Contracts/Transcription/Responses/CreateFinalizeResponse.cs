namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response for finalizing a transcription job.
    /// </summary>
    public class CreateFinalizeResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the job.
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// Gets or sets the job status.
        /// </summary>
        public bool? JobFinalized { get; set; }
    }
}

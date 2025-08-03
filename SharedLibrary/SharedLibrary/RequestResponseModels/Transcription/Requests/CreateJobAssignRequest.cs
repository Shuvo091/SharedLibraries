namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to assign a job to a transcriber.
    /// </summary>
    public class CreateJobAssignRequest
    {
        /// <summary>
        /// Gets or sets the workflow request identifier.
        /// </summary>
        public Guid? WorkflowRequestId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the claim identifier.
        /// </summary>
        public Guid ClaimId { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence number.
        /// </summary>
        public int? TranscriptionSequence { get; set; }

        /// <summary>
        /// Gets or sets the name of the person who assigned the job.
        /// </summary>
        public string? AssignedBy { get; set; }

        /// <summary>
        /// Gets or sets any notes related to the assignment.
        /// </summary>
        public string? Notes { get; set; }
    }
}
namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response after assigning a job to a transcriber.
    /// </summary>
    public class CreateJobAssignResponse
    {
        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        public Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the status of the job assignment.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was assigned.
        /// </summary>
        public DateTime? AssignedAt { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the job.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence number.
        /// </summary>
        public int? TranscriptionSequence { get; set; }

        /// <summary>
        /// Gets or sets the session identifier.
        /// </summary>
        public Guid? SessionId { get; set; }

        /// <summary>
        /// Gets or sets the websocket URL for the job.
        /// </summary>
        public string? WebsocketUrl { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI comparison response for the job assignment.
        /// </summary>
        public JobAssignOpenaiComparisonResponse? OpenAiComparison { get; set; }

        /// <summary>
        /// Gets or sets the error message, if any.
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// Gets or sets the informational message, if any.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets the number of transcribers needed.
        /// </summary>
        public int? TranscribersNeeded { get; set; }

        /// <summary>
        /// Gets or sets the current number of transcribers assigned.
        /// </summary>
        public int? CurrentTranscribers { get; set; }
    }

    /// <summary>
    /// Represents the OpenAI comparison response for a job assignment.
    /// </summary>
    public class JobAssignOpenaiComparisonResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether OpenAI comparison is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the similarity threshold for OpenAI comparison.
        /// </summary>
        public int? SimilarityThreshold { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether awaiting a second transcriber.
        /// </summary>
        public bool? AwaitingSecondTranscriber { get; set; }
    }
}
namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the response after submitting a completed transcription.
    /// </summary>
    public class CreateSubmitResponse
    {
        /// <summary>
        /// Gets or sets the submission identifier.
        /// </summary>
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// Gets or sets the status of the submission.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transcription was submitted.
        /// </summary>
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Gets or sets the next step after submission.
        /// </summary>
        public string? NextStep { get; set; }

        /// <summary>
        /// Gets or sets the turnaround time for the submission.
        /// </summary>
        public string? TurnaroundTime { get; set; }

        /// <summary>
        /// Gets or sets the OpenAI comparison response for the submission.
        /// </summary>
        public CreateSubmitOpenaiComparisonResponse? OpenaiComparison { get; set; }
    }

    /// <summary>
    /// Represents the OpenAI comparison response for a transcription submission.
    /// </summary>
    public class CreateSubmitOpenaiComparisonResponse
    {
        /// <summary>
        /// Gets or sets the status of the OpenAI comparison.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the submission is ready for comparison.
        /// </summary>
        public bool? ReadyForComparison { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence number.
        /// </summary>
        public int? TranscriptionSequence { get; set; }
    }
}
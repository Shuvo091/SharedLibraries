namespace SharedLibrary.Contracts.Transcription.Responses
{
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
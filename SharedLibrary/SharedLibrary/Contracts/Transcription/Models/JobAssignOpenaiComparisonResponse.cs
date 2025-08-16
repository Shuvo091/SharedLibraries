namespace SharedLibrary.Contracts.Transcription.Responses
{
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
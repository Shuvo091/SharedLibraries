namespace SharedLibrary.Contracts.Transcription.Responses
{
    /// <summary>
    /// Represents the response after creating a draft.
    /// </summary>
    public class CreateDraftsResponse
    {
        /// <summary>
        /// Gets or sets the draft identifier.
        /// </summary>
        public Guid DraftId { get; set; }

        /// <summary>
        /// Gets or sets the version of the draft.
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the draft was saved.
        /// </summary>
        public DateTime? SavedAt { get; set; }

        /// <summary>
        /// Gets or sets the word count of the draft.
        /// </summary>
        public int? WordCount { get; set; }

        /// <summary>
        /// Gets or sets the estimated completion value.
        /// </summary>
        public int? EstimatedCompletion { get; set; }
    }
}
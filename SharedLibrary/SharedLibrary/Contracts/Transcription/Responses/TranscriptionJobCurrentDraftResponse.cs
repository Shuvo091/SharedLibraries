namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents the current draft for a transcription job.
    /// </summary>
    public class TranscriptionJobCurrentDraftResponse
    {
        /// <summary>
        /// Gets or sets the text of the current draft.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the word count of the current draft.
        /// </summary>
        public int? WordCount { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the draft was last saved.
        /// </summary>
        public DateTime? LastSaved { get; set; }

        /// <summary>
        /// Gets or sets the version of the current draft.
        /// </summary>
        public int? Version { get; set; }
    }
}
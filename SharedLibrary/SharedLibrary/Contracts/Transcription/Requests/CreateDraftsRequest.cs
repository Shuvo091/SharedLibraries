namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a request to create a draft.
    /// </summary>
    public class CreateDraftsRequest
    {
        /// <summary>
        /// Gets or sets the draft text.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the cursor position in the draft.
        /// </summary>
        public int? CursorPosition { get; set; }

        /// <summary>
        /// Gets or sets the selected text in the draft.
        /// </summary>
        public string? SelectedText { get; set; }

        /// <summary>
        /// Gets or sets the list of timestamps for the draft.
        /// </summary>
        public List<DraftsTimestampsRequest>? Timestamps { get; set; }

        /// <summary>
        /// Gets or sets the confidence value for the draft.
        /// </summary>
        public int? Confidence { get; set; }
    }
}
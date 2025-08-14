using Azure.Core;

namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to set or update a draft in the system.
    /// </summary>
    public class SetDraftRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the draft.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of when the draft was created or last updated.
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the job associated with the draft.
        /// </summary>
        public int? CursorPosition { get; set; }

        /// <summary>
        /// Gets or sets the version number of the entity.
        /// </summary>
        public int? Version { get; set; }
    }
}

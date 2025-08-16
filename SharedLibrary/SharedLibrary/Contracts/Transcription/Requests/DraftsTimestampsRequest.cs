namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents a timestamp entry for a draft.
    /// </summary>
    public class DraftsTimestampsRequest
    {
        /// <summary>
        /// Gets or sets the position of the timestamp.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets the time value.
        /// </summary>
        public string? Time { get; set; }
    }
}
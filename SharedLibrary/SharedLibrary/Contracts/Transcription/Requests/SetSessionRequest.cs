namespace SharedLibrary.Contracts.Transcription.Requests
{
    /// <summary>
    /// Represents a request to set the session for a user in the transcription service.
    /// </summary>
    public class SetSessionRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the current session.
        /// </summary>
        public Guid SessionId { get; set; }

        /// <summary>
        /// Gets or sets the URL of the WebSocket endpoint.
        /// </summary>
        public string? WebSocketUrl { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the user associated with the session.
        /// </summary>
        public bool? Status { get; set; }
    }
}

namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents access configuration settings for admin.
    /// </summary>
    public class AdminAccessConfigResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether open access is enabled.
        /// </summary>
        public bool? OpenAccessEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Elo-based job claiming is enabled.
        /// </summary>
        public bool? EloBasedJobClaiming { get; set; }

        /// <summary>
        /// Gets or sets the job difficulty removal setting.
        /// </summary>
        public string? RemoveJobDifficulty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether chess-style Elo is enabled.
        /// </summary>
        public bool? ChessStyleElo { get; set; }
    }
}
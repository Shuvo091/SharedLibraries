namespace SharedLibrary.Contracts.Transcription.Models
{
    /// <summary>
    /// Represents Elo configuration settings for admin update.
    /// </summary>
    public class AdminEloConfigRequest
    {
        /// <summary>
        /// Gets or sets the Elo K-factor.
        /// </summary>
        public int? EloKFactor { get; set; }

        /// <summary>
        /// Gets or sets the multi-transcriber threshold.
        /// </summary>
        public int? MultiTranscriberThreshold { get; set; }
    }
}
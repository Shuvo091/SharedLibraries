namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    /// <summary>
    /// Represents Elo configuration settings for admin.
    /// </summary>
    public class AdminEloConfigResponse
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
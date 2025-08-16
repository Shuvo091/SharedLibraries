namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    /// <summary>
    /// Represents the data for a completed transcription.
    /// </summary>
    public class TranscriptionDataRequest
    {
        /// <summary>
        /// Gets or sets the content of the transcription.
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// Gets or sets the transcription sequence number.
        /// </summary>
        public int? TranscriptionSequence { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transcription was submitted.
        /// </summary>
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Gets or sets the time spent on the transcription.
        /// </summary>
        public string? TimeSpent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transcriber is a professional.
        /// </summary>
        public bool? IsProfessional { get; set; }
    }
}
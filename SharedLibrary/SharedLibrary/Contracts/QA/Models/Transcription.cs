namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents a transcription submitted for comparison.
/// </summary>
public class Transcription
{
    /// <summary>
    /// Gets or sets transcription identifier.
    /// </summary>
    required public Guid TranscriptionId { get; set; }

    /// <summary>
    /// Gets or sets transcriber identifier.
    /// </summary>
    required public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets transcription content.
    /// </summary>
    required public string Content { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo rating.
    /// </summary>
    required public double TranscriberElo { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the transcriber is a professional.
    /// </summary>
    required public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets date and time the transcription was submitted.
    /// </summary>
    required public DateTime SubmittedAt { get; set; }
}

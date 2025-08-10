using SharedLibrary.Contracts.QA.Enums;

namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Recommendation for Elo changes after comparison.
/// </summary>
public class EloRecommendation
{
    /// <summary>
    /// Gets or sets transcriber identifier.
    /// </summary>
    required public string TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets transcription identifier.
    /// </summary>
    required public string TranscriptionId { get; set; }

    /// <summary>
    /// Gets or sets role of the transcriber in the comparison.
    /// </summary>
    public ParticipantRole Role { get; set; }

    /// <summary>
    /// Gets or sets current Elo rating.
    /// </summary>
    public double CurrentElo { get; set; }

    /// <summary>
    /// Gets or sets recommended Elo change.
    /// </summary>
    public double RecommendedChange { get; set; }

    /// <summary>
    /// Gets or sets new Elo rating after change.
    /// </summary>
    public double NewElo { get; set; }

    /// <summary>
    /// Gets or sets outcome of the comparison for the transcriber.
    /// </summary>
    public ComparisonOutcome OutCome { get; set; }
}

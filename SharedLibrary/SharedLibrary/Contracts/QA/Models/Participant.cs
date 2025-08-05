using SharedLibrary.Contracts.QA.Enums;

namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents a participant in a transcription process, including identifiers for the transcription and transcriber, as
/// well as the outcome of a comparison.
/// </summary>
public class Participant
{
    /// <summary>
    /// Gets or sets the transcription identifier.
    /// </summary>
    required public Guid TranscriptionId { get; set; }

    /// <summary>
    /// Gets or sets the transcriber identifier.
    /// </summary>
    required public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets the outcome of the comparison for the participant.
    /// </summary>
    public ComparisonOutcome Outcome { get; set; }
}

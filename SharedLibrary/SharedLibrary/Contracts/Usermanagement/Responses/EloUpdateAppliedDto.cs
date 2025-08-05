namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Data transfer object representing an applied Elo update.
/// </summary>
public class EloUpdateAppliedDto
{
    /// <summary>
    /// Gets or sets unique identifier for the transcriber.
    /// </summary>
    public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo before the update.
    /// </summary>
    public int OldElo { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo after the update.
    /// </summary>
    public int NewElo { get; set; }

    /// <summary>
    /// Gets or sets amount of Elo change applied.
    /// </summary>
    public int EloChange { get; set; }

    /// <summary>
    /// Gets or sets outcome of the comparison for the transcriber.
    /// </summary>
    public string? ComparisonOutcome { get; set; }
}
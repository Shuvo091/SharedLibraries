using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Data transfer object representing a recommended Elo change for a transcriber.
/// </summary>
public class RecommendedEloChangeDto
{
    /// <summary>
    /// Gets or sets unique identifier for the transcriber.
    /// </summary>
    [Required(ErrorMessage = "TranscriberId is required.")]
    public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets transcriber's Elo before the change.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "OldElo must be 0 or greater.")]
    public int OldElo { get; set; }

    /// <summary>
    /// Gets or sets recommended Elo change value.
    /// </summary>
    [Range(-1000, 1000, ErrorMessage = "RecommendedChange must be between -1000 and 1000.")]
    public int RecommendedChange { get; set; }

    /// <summary>
    /// Gets or sets outcome of the comparison for the transcriber.
    /// </summary>
    [Required(ErrorMessage = "ComparisonOutcome is required.")]
    public string? ComparisonOutcome { get; set; }

    /// <summary>
    /// Gets or sets elo rating of the opponent.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "OpponentElo must be 0 or greater.")]
    public int OpponentElo { get; set; }
}

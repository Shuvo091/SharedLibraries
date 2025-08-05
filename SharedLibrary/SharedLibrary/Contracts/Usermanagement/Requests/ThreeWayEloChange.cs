using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Data transfer object representing an Elo change in a three-way comparison.
/// </summary>
public class ThreeWayEloChange
{
    /// <summary>
    /// Gets or sets unique identifier for the transcriber.
    /// </summary>
    [Required(ErrorMessage = "TranscriberId is required.")]
    public Guid TranscriberId { get; set; }

    /// <summary>
    /// Gets or sets role of the transcriber in the comparison.
    /// </summary>
    [Required(ErrorMessage = "Role is required.")]
    [MinLength(1, ErrorMessage = "Role cannot be empty.")]
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets outcome for the transcriber in the comparison.
    /// </summary>
    [Required(ErrorMessage = "Outcome is required.")]
    [MinLength(1, ErrorMessage = "Outcome cannot be empty.")]
    public string Outcome { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets amount of Elo change applied.
    /// </summary>
    public int EloChange { get; set; }

    /// <summary>
    /// Gets or sets new Elo rating after the change.
    /// </summary>
    public int NewElo { get; set; }

    /// <summary>
    /// Gets or sets tiebreaker bonus details, if applicable.
    /// </summary>
    public TiebreakerBonus? TiebreakerBonus { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Request to validate a tiebreaker claim for a job.
/// </summary>
public class ValidateTiebreakerClaimRequest
{
    /// <summary>
    /// Gets or sets the original job identifier.
    /// </summary>
    [Required(ErrorMessage = "OriginalJobId is required.")]
    [MinLength(1, ErrorMessage = "OriginalJobId cannot be empty.")]
    public string OriginalJobId { get; set; } = default!;

    /// <summary>
    /// Gets or sets the tiebreaker request identifier.
    /// </summary>
    [Required(ErrorMessage = "TiebreakerRequestId is required.")]
    [MinLength(1, ErrorMessage = "TiebreakerRequestId cannot be empty.")]
    public string TiebreakerRequestId { get; set; } = default!;

    /// <summary>
    /// Gets or sets the urgency of the tiebreaker claim.
    /// </summary>
    [Required(ErrorMessage = "Urgency is required.")]
    [MinLength(1, ErrorMessage = "Urgency cannot be empty.")]
    public string Urgency { get; set; } = default!;

    /// <summary>
    /// Gets or sets the deadline for the tiebreaker.
    /// </summary>
    [Required(ErrorMessage = "TiebreakerDeadline is required.")]
    public DateTime TiebreakerDeadline { get; set; }

    /// <summary>
    /// Gets or sets the bonus multiplier for the tiebreaker claim.
    /// </summary>
    [Range(0.0, double.MaxValue, ErrorMessage = "BonusMultiplier must be zero or positive.")]
    public double BonusMultiplier { get; set; }

    /// <summary>
    /// Gets or sets the required minimum Elo for the tiebreaker claim.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "RequiredMinElo must be zero or positive.")]
    public int RequiredMinElo { get; set; }

    /// <summary>
    /// Gets or sets the list of original transcribers.
    /// </summary>
    [Required(ErrorMessage = "OriginalTranscribers list is required.")]
    [MinLength(2, ErrorMessage = "At least two original transcriber is required.")]
    public List<Guid> OriginalTranscribers { get; set; } = new ();
}
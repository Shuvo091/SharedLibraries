using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Response after validating a tiebreaker claim.
/// </summary>
public class ValidateTiebreakerClaimResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether the tiebreaker claim was validated.
    /// </summary>
    public bool TiebreakerClaimValidated { get; set; }

    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    public Guid UserId { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the user's Elo is qualified.
    /// </summary>
    public bool UserEloQualified { get; set; }

    /// <summary>
    /// Gets or sets the user's current Elo rating.
    /// </summary>
    public int CurrentElo { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the user is an original transcriber.
    /// </summary>
    public bool IsOriginalTranscriber { get; set; }

    /// <summary>
    /// Gets or sets the claim identifier.
    /// </summary>
    public string ClaimId { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the bonus is confirmed.
    /// </summary>
    public bool BonusConfirmed { get; set; }

    /// <summary>
    /// Gets or sets the estimated completion time (e.g., "45m").
    /// </summary>
    public string EstimatedCompletion { get; set; } = default!;
}

/// <summary>
/// Response when a tiebreaker claim is forbidden.
/// </summary>
public class TiebreakerClaimForbiddenResponse
{
    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    public string Error { get; set; } = "original_transcriber_not_eligible";

    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    public string Message { get; set; } = "Users who participated in the original transcription cannot be tiebreakers";

    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    public string UserId { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the user was an original transcriber.
    /// </summary>
    public bool WasOriginalTranscriber { get; set; }
}
namespace SharedLibrary.Contracts.Usermanagement.Responses;

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
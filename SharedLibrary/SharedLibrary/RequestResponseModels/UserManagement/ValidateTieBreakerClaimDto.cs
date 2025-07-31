using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Validate Tie Breaker Claim Request
public class ValidateTiebreakerClaimRequest
{
	[Required(ErrorMessage = "OriginalJobId is required.")]
	[MinLength(1, ErrorMessage = "OriginalJobId cannot be empty.")]
	public string OriginalJobId { get; set; } = default!;

	[Required(ErrorMessage = "TiebreakerRequestId is required.")]
	[MinLength(1, ErrorMessage = "TiebreakerRequestId cannot be empty.")]
	public string TiebreakerRequestId { get; set; } = default!;

	[Required(ErrorMessage = "Urgency is required.")]
	[MinLength(1, ErrorMessage = "Urgency cannot be empty.")]
	public string Urgency { get; set; } = default!;

	[Required(ErrorMessage = "TiebreakerDeadline is required.")]
	public DateTime TiebreakerDeadline { get; set; }

	[Range(0.0, double.MaxValue, ErrorMessage = "BonusMultiplier must be zero or positive.")]
	public double BonusMultiplier { get; set; }

	[Range(0, int.MaxValue, ErrorMessage = "RequiredMinElo must be zero or positive.")]
	public int RequiredMinElo { get; set; }

	[Required(ErrorMessage = "OriginalTranscribers list is required.")]
	[MinLength(2, ErrorMessage = "At least two original transcriber is required.")]
	public List<Guid> OriginalTranscribers { get; set; } = new();
}


#endregion


#region Validate Tie Breaker Claim Response

public class ValidateTiebreakerClaimResponse
{
    public bool TiebreakerClaimValidated { get; set; }
    public Guid UserId { get; set; } = default!;
    public bool UserEloQualified { get; set; }
    public int CurrentElo { get; set; }
    public bool IsOriginalTranscriber { get; set; }
    public string ClaimId { get; set; } = default!;
    public bool BonusConfirmed { get; set; }
    public string EstimatedCompletion { get; set; } = default!; // e.g. "45m"
}

public class TiebreakerClaimForbiddenResponse
{
    public string Error { get; set; } = "original_transcriber_not_eligible";
    public string Message { get; set; } = "Users who participated in the original transcription cannot be tiebreakers";
    public string UserId { get; set; } = default!;
    public bool WasOriginalTranscriber { get; set; }
}

#endregion
namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Validate Tie Breaker Claim Request
public class ValidateTiebreakerClaimRequest
{
	public string OriginalJobId { get; set; } = default!;
	public string TiebreakerRequestId { get; set; } = default!;
	public string Urgency { get; set; } = default!;
	public DateTime TiebreakerDeadline { get; set; }
	public double BonusMultiplier { get; set; }
	public int RequiredMinElo { get; set; }
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
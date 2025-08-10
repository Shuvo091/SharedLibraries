namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response after claiming a job.
/// </summary>
public class ClaimJobResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the claim was validated.
    /// </summary>
    public bool ClaimValidated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is eligible for the job.
    /// </summary>
    public bool UserEligible { get; set; }

    /// <summary>
    /// Gets or sets unique identifier for the claim.
    /// </summary>
    public Guid ClaimId { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's availability status.
    /// </summary>
    public string UserAvailability { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's current workload.
    /// </summary>
    public int CurrentWorkload { get; set; }

    /// <summary>
    /// Gets or sets maximum number of concurrent jobs allowed for the user.
    /// </summary>
    public int MaxConcurrentJobs { get; set; }

    /// <summary>
    /// Gets or sets current elo for the user.
    /// </summary>
    public int CurrentElo { get; set; }

    /// <summary>
    /// Gets or sets time until which the user's capacity is reserved.
    /// </summary>
    public DateTime CapacityReservedUntil { get; set; }
}
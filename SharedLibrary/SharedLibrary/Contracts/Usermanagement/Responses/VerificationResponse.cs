namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response after performing user verification.
/// </summary>
public class VerificationResponse
{
    /// <summary>
    /// Gets or sets the verification status.
    /// </summary>
    public string VerificationStatus { get; set; } = default!;

    /// <summary>
    /// Gets or sets the user's Elo rating after verification.
    /// </summary>
    public int EloRating { get; set; }

    /// <summary>
    /// Gets or sets the status change message.
    /// </summary>
    public string StatusChanged { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the user is eligible for work.
    /// </summary>
    public bool EligibleForWork { get; set; }

    /// <summary>
    /// Gets or sets the activation method used.
    /// </summary>
    public string ActivationMethod { get; set; } = default!;

    /// <summary>
    /// Gets or sets the date and time when the user was activated.
    /// </summary>
    public DateTime ActivatedAt { get; set; }

    /// <summary>
    /// Gets or sets the verification level achieved.
    /// </summary>
    public string VerificationLevel { get; set; } = default!;

    /// <summary>
    /// Gets or sets the next steps for the user.
    /// </summary>
    public string[] NextSteps { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets a note about the roadmap for the user.
    /// </summary>
    public string RoadmapNote { get; set; } = default!;
}
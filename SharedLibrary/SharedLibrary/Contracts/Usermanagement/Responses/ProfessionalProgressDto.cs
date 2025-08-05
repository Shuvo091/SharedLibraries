namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Progress details towards professional status.
/// </summary>
public class ProfessionalProgressDto
{
    /// <summary>
    /// Gets or sets progress in Elo rating.
    /// </summary>
    public string EloProgress { get; set; } = default!;

    /// <summary>
    /// Gets or sets progress in jobs completed.
    /// </summary>
    public string JobsProgress { get; set; } = default!;
}

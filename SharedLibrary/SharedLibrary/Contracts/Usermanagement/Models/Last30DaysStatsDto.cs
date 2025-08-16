namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Statistics for the last 30 days.
/// </summary>
public class Last30DaysStatsDto
{
    /// <summary>
    /// Gets or sets number of jobs completed in the last 30 days.
    /// </summary>
    public int JobsCompleted { get; set; }

    /// <summary>
    /// Gets or sets elo change in the last 30 days.
    /// </summary>
    public string EloChange { get; set; } = default!;

    /// <summary>
    /// Gets or sets earnings in the last 30 days.
    /// </summary>
    public double Earnings { get; set; }
}

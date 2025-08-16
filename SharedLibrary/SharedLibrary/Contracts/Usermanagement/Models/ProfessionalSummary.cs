namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Summary of professional status statistics for a batch.
/// </summary>
public class ProfessionalSummary
{
    /// <summary>
    /// Gets or sets total number of users checked.
    /// </summary>
    public int TotalChecked { get; set; }

    /// <summary>
    /// Gets or sets number of users who are professionals.
    /// </summary>
    public int Professionals { get; set; }

    /// <summary>
    /// Gets or sets number of users who are standard transcribers.
    /// </summary>
    public int StandardTranscribers { get; set; }
}
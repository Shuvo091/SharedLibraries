namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Data associated with an Elo update event.
/// </summary>
public class EloUpdateEventData
{
    /// <summary>
    /// Gets or sets unique identifier for the comparison.
    /// </summary>
    public Guid ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets number of users whose Elo was updated.
    /// </summary>
    public int UsersUpdated { get; set; }

    /// <summary>
    /// Gets or sets list of results for each user update.
    /// </summary>
    public List<EloUpdateResult> UpdateResults { get; set; } = [];
}

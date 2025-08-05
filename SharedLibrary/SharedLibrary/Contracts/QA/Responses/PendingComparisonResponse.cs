using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Response for pending comparisons by job.
/// </summary>
public class PendingComparisonResponse
{
    /// <summary>
    /// Gets or sets job identifier.
    /// </summary>
    required public Guid JobId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there are pending comparisons to be processed.
    /// </summary>
    public bool HasPendingComparisons { get; set; }

    /// <summary>
    /// Gets or sets list of comparisons.
    /// </summary>
    required public List<PendingComparisonDto> Comparisons { get; set; }
}

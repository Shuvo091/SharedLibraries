using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Represents the response for a batch comparison audit, including audit results and cost breakdown.
/// </summary>
public class BatchComparisonAuditResponse
{
    /// <summary>
    /// Gets or sets the unique identifier for the audit.
    /// </summary>
    public string AuditId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the status of the audit.
    /// </summary>
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the completion date and time of the audit, if completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Gets or sets the results of the audit.
    /// </summary>
    public AuditResultsDto? AuditResults { get; set; }

    /// <summary>
    /// Gets or sets the cost breakdown for the audit.
    /// </summary>
    public CostBreakdownDto? CostBreakdown { get; set; }
}

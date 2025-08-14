using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Represents the response for a batch comparison audit, including audit details and progress.
/// </summary>
public class BatchComparisonResponse
{
    /// <summary>
    /// Gets or sets the unique identifier for the audit.
    /// </summary>
    public string AuditId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the current status of the audit.
    /// </summary>
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the estimated completion date and time of the audit.
    /// </summary>
    public DateTime EstimatedCompletion { get; set; }

    /// <summary>
    /// Gets or sets the number of samples selected for the audit.
    /// </summary>
    public int SamplesSelected { get; set; }

    /// <summary>
    /// Gets or sets the estimated cost of the audit.
    /// </summary>
    public decimal EstimatedCost { get; set; }

    /// <summary>
    /// Gets or sets the progress details of the audit.
    /// </summary>
    public AuditProgress? AuditProgress { get; set; }
}
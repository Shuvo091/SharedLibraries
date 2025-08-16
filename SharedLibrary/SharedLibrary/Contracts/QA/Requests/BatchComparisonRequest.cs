using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Requests;

/// <summary>
/// Represents a request for batch comparison in QA processes.
/// </summary>
public class BatchComparisonRequest
{
    /// <summary>
    /// Gets or sets the type of audit to perform.
    /// </summary>
    public string AuditType { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sampling rate for the batch comparison.
    /// </summary>
    public double SamplingRate { get; set; }

    /// <summary>
    /// Gets or sets the time range for the batch comparison.
    /// </summary>
    required public TimeRangeDto TimeRange { get; set; }

    /// <summary>
    /// Gets or sets the filters to apply during the batch comparison.
    /// </summary>
    required public FiltersDto Filters { get; set; }

    /// <summary>
    /// Gets or sets the list of audit criteria for the batch comparison.
    /// </summary>
    public List<string> AuditCriteria { get; set; } = [];
}

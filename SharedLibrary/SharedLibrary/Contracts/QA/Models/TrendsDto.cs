namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Contains trend information identified in the audit.
/// </summary>
public class TrendsDto
{
    /// <summary>
    /// Gets or sets the trend for OpenAI accuracy over time.
    /// </summary>
    public string OpenaiAccuracyTrend { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the trend for Elo calculation accuracy over time.
    /// </summary>
    public string EloCalculationTrend { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the list of emerging issues identified in the audit.
    /// </summary>
    public List<string>? EmergingIssues { get; set; }
}

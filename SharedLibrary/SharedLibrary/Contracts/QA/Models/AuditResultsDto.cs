namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Contains detailed results of a batch comparison audit.
/// </summary>
public class AuditResultsDto
{
    /// <summary>
    /// Gets or sets the overall system quality score.
    /// </summary>
    public double OverallSystemQuality { get; set; }

    /// <summary>
    /// Gets or sets the number of samples processed in the audit.
    /// </summary>
    public int SamplesProcessed { get; set; }

    /// <summary>
    /// Gets or sets the comparison accuracy details.
    /// </summary>
    public ComparisonAccuracyDto? ComparisonAccuracy { get; set; }

    /// <summary>
    /// Gets or sets the analysis of Elo recommendations.
    /// </summary>
    public EloRecommendationAnalysisDto? EloRecommendationAnalysis { get; set; }

    /// <summary>
    /// Gets or sets the list of outliers detected in the audit.
    /// </summary>
    public List<OutlierDto>? Outliers { get; set; }

    /// <summary>
    /// Gets or sets the trends identified in the audit.
    /// </summary>
    public TrendsDto? Trends { get; set; }
}

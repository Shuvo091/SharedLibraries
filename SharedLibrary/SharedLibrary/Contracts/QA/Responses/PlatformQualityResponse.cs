using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Represents the quality response for a platform within a specific timeframe.
/// </summary>
public class PlatformQualityResponse
{
    /// <summary>
    /// Gets or sets the timeframe for the quality response.
    /// </summary>
    required public string Timeframe { get; set; }

    /// <summary>
    /// Gets or sets the platform metrics.
    /// </summary>
    required public PlatformMetrics PlatformMetrics { get; set; }

    /// <summary>
    /// Gets or sets the quality distribution.
    /// </summary>
    required public QualityDistribution QualityDistribution { get; set; }

    /// <summary>
    /// Gets or sets the dialect performance metrics, keyed by dialect name.
    /// </summary>
    required public Dictionary<string, DialectPerformance> DialectPerformance { get; set; }

    /// <summary>
    /// Gets or sets the Elo recommendation statistics.
    /// </summary>
    required public EloRecommendationStats EloRecommendationStats { get; set; }
}

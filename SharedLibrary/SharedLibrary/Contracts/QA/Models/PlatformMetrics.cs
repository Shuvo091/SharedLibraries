namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents platform-level metrics.
/// </summary>
public class PlatformMetrics
{
    /// <summary>
    /// Gets or sets the total number of comparisons.
    /// </summary>
    public int TotalComparisons { get; set; }

    /// <summary>
    /// Gets or sets the average confidence score.
    /// </summary>
    public double AverageConfidence { get; set; }

    /// <summary>
    /// Gets or sets the rate of tiebreakers.
    /// </summary>
    public double TiebreakerRate { get; set; }

    /// <summary>
    /// Gets or sets the cost per comparison.
    /// </summary>
    public double CostPerComparison { get; set; }

    /// <summary>
    /// Gets or sets the OpenAI accuracy rate.
    /// </summary>
    public double OpenaiAccuracy { get; set; }
}

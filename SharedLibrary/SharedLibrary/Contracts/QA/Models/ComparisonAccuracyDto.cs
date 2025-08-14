namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents accuracy metrics for comparison operations.
/// </summary>
public class ComparisonAccuracyDto
{
    /// <summary>
    /// Gets or sets the accuracy score for OpenAI comparisons.
    /// </summary>
    public double OpenaiAccuracy { get; set; }

    /// <summary>
    /// Gets or sets the accuracy score for Elo calculations.
    /// </summary>
    public double EloCalculationAccuracy { get; set; }

    /// <summary>
    /// Gets or sets the fairness score for tiebreaker decisions.
    /// </summary>
    public double TiebreakerFairness { get; set; }

    /// <summary>
    /// Gets or sets the consistency score for linguistic analysis.
    /// </summary>
    public double LinguisticConsistency { get; set; }
}

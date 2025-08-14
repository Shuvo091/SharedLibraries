namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents performance metrics for a specific dialect.
/// </summary>
public class DialectPerformance
{
    /// <summary>
    /// Gets or sets the number of comparisons for the dialect.
    /// </summary>
    public int Comparisons { get; set; }

    /// <summary>
    /// Gets or sets the average confidence score for the dialect.
    /// </summary>
    public double AverageConfidence { get; set; }

    /// <summary>
    /// Gets or sets the tiebreaker rate for the dialect.
    /// </summary>
    public double TiebreakerRate { get; set; }
}
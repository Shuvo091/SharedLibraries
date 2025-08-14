namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents statistics for Elo recommendations.
/// </summary>
public class EloRecommendationStats
{
    /// <summary>
    /// Gets or sets the total recommendations.
    /// </summary>
    public double TotalRecommendations { get; set; }

    /// <summary>
    /// Gets or sets the average Elo change.
    /// </summary>
    public double AverageChange { get; set; }

    /// <summary>
    /// Gets or sets the largest Elo change.
    /// </summary>
    public double LargestChange { get; set; }

    /// <summary>
    /// Gets or sets the smallest Elo change.
    /// </summary>
    public double SmallestChange { get; set; }
}
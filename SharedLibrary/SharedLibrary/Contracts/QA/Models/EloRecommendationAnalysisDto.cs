namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Contains analysis of Elo recommendation calculations.
/// </summary>
public class EloRecommendationAnalysisDto
{
    /// <summary>
    /// Gets or sets the percentage of correctly calculated recommendations.
    /// </summary>
    public double CorrectlyCalculated { get; set; }

    /// <summary>
    /// Gets or sets the percentage of recommendations with minor discrepancies.
    /// </summary>
    public double MinorDiscrepancies { get; set; }

    /// <summary>
    /// Gets or sets the percentage of recommendations with major discrepancies.
    /// </summary>
    public double MajorDiscrepancies { get; set; }
}

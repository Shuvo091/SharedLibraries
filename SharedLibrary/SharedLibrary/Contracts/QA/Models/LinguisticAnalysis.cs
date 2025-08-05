namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Linguistic analysis details for a comparison.
/// </summary>
public class LinguisticAnalysis
{
    /// <summary>
    /// Gets or sets semantic accuracy score.
    /// </summary>
    public double SemanticAccuracy { get; set; }

    /// <summary>
    /// Gets or sets grammatical accuracy score.
    /// </summary>
    public double GrammaticalAccuracy { get; set; }

    /// <summary>
    /// Gets or sets dialect authenticity score.
    /// </summary>
    public double DialectAuthenticity { get; set; }
}

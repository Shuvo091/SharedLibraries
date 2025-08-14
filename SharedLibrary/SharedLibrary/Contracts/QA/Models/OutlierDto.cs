namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents an outlier detected during the audit.
/// </summary>
public class OutlierDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the comparison associated with the outlier.
    /// </summary>
    public string ComparisonId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the issue detected.
    /// </summary>
    public string Issue { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the confidence score for the outlier detection.
    /// </summary>
    public double Confidence { get; set; }

    /// <summary>
    /// Gets or sets the recommended action for the outlier.
    /// </summary>
    public string RecommendedAction { get; set; } = string.Empty;
}

namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents the distribution of quality levels.
/// </summary>
public class QualityDistribution
{
    /// <summary>
    /// Gets or sets the proportion of high quality items.
    /// </summary>
    public double HighQuality { get; set; }

    /// <summary>
    /// Gets or sets the proportion of medium quality items.
    /// </summary>
    public double MediumQuality { get; set; }

    /// <summary>
    /// Gets or sets the proportion of low quality items.
    /// </summary>
    public double LowQuality { get; set; }
}
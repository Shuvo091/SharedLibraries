namespace SharedLibrary.Contracts.QA.Requests;

/// <summary>
/// Represents a request to configure professional spot checks.
/// </summary>
public class ProfessionalSpotCheckRequest
{
    /// <summary>
    /// Gets or sets the spot check configuration.
    /// </summary>
    public Configuration? Configuration { get; set; }

    /// <summary>
    /// Gets or sets the filters for selecting professionals.
    /// </summary>
    public ProfessionalFilters? ProfessionalFilters { get; set; }
}

/// <summary>
/// Represents the configuration for professional spot checks.
/// </summary>
public class Configuration
{
    /// <summary>
    /// Gets or sets the percentage of spot checks to perform.
    /// </summary>
    public double? SpotCheckPercentage { get; set; }

    /// <summary>
    /// Gets or sets the minimum sample size for spot checks.
    /// </summary>
    public double? MinimumSampleSize { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of checks per day.
    /// </summary>
    public double? MaxChecksPerDay { get; set; }

    /// <summary>
    /// Gets or sets the quality threshold for spot checks.
    /// </summary>
    public double? QualityThreshold { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether random sampling is enabled.
    /// </summary>
    public bool? EnableRandomSampling { get; set; }
}

/// <summary>
/// Represents filters for selecting professionals for spot checks.
/// </summary>
public class ProfessionalFilters
{
    /// <summary>
    /// Gets or sets the minimum Elo rating required.
    /// </summary>
    public double? MinEloRating { get; set; }

    /// <summary>
    /// Gets or sets the list of dialects to include.
    /// </summary>
    public List<string>? IncludeDialects { get; set; }

    /// <summary>
    /// Gets or sets the time range for filtering professionals.
    /// </summary>
    public string? TimeRange { get; set; }
}
namespace SharedLibrary.RequestResponseModels.QA.ProfessionalSpotCheckConfig;

/// <summary>
/// Represents the response for a professional spot check configuration request.
/// </summary>
public class ProfessionalSpotCheckResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether the spot check configuration was updated.
    /// </summary>
    required public bool SpotCheckConfigUpdated { get; set; }

    /// <summary>
    /// Gets or sets the configuration for spot checks.
    /// </summary>
    required public Configuration Configuration { get; set; }

    /// <summary>
    /// Gets or sets the estimated cost for spot checks.
    /// </summary>
    required public EstimatedCost EstimatedCost { get; set; }

    /// <summary>
    /// Gets or sets the effective date from which the configuration applies.
    /// </summary>
    required public string EffectiveFrom { get; set; }
}

/// <summary>
/// Represents the estimated cost for spot checks.
/// </summary>
public class EstimatedCost
{
    /// <summary>
    /// Gets or sets the daily estimated cost.
    /// </summary>
    public double DailyEstimate { get; set; }

    /// <summary>
    /// Gets or sets the monthly estimated cost.
    /// </summary>
    public double MonthlyEstimate { get; set; }
}
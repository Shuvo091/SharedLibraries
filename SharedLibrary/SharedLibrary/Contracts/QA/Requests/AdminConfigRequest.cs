using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.QA.Requests;

/// <summary>
/// Represents the request for admin configuration.
/// </summary>
public class AdminConfigRequest
{
    /// <summary>
    /// Gets or sets the comparison workflow configuration.
    /// </summary>
    public ComparisonWorkflowConfig? ComparisonWorkflowConfig { get; set; }

    /// <summary>
    /// Gets or sets the Elo calculation configuration.
    /// </summary>
    public EloCalculationConfig? EloCalculationConfig { get; set; }

    /// <summary>
    /// Gets or sets the OpenAI integration configuration.
    /// </summary>
    public OpenaiIntegrationConfig? OpenaiIntegrationConfig { get; set; }

    /// <summary>
    /// Gets or sets the tiebreaker configuration.
    /// </summary>
    public TiebreakerConfig? TiebreakerConfig { get; set; }

    /// <summary>
    /// Gets or sets the professional QA configuration.
    /// </summary>
    public ProfessionalQaConfig? ProfessionalQaConfig { get; set; }
}

/// <summary>
/// Represents the configuration for comparison workflow.
/// </summary>
public class ComparisonWorkflowConfig
{
    /// <summary>Gets or sets a value indicating whether OpenAI scoring is enabled.</summary>
    public bool? OpenaiScoringEnabled { get; set; }

    /// <summary>Gets or sets the OpenAI confidence threshold.</summary>
    public double? OpenaiConfidenceThreshold { get; set; }

    /// <summary>Gets or sets the tiebreaker threshold.</summary>
    public double? TiebreakerThreshold { get; set; }

    /// <summary>Gets or sets the similarity threshold.</summary>
    public double? SimilarityThreshold { get; set; }

    /// <summary>Gets or sets a value indicating whether auto processing is enabled.</summary>
    public bool? AutoProcessingEnabled { get; set; }
}

/// <summary>
/// Represents the configuration for Elo calculation.
/// </summary>
public class EloCalculationConfig
{
    /// <summary>Gets or sets the K factors.</summary>
    public KFactors? KFactors { get; set; }

    /// <summary>Gets or sets the rating boundaries.</summary>
    public RatingBounderies? RatingBoundaries { get; set; }
}

/// <summary>
/// Represents the K factors for Elo calculation.
/// </summary>
public class KFactors
{
    /// <summary>Gets or sets the novice K factor.</summary>
    public double? Novice { get; set; }

    /// <summary>Gets or sets the intermediate K factor.</summary>
    public double? Intermediate { get; set; }

    /// <summary>Gets or sets the advanced K factor.</summary>
    public double? Advanced { get; set; }

    /// <summary>Gets or sets the expert K factor.</summary>
    public double? Expert { get; set; }
}

/// <summary>
/// Represents the rating boundaries for Elo calculation.
/// </summary>
public class RatingBounderies
{
    /// <summary>Gets or sets the novice rating boundary.</summary>
    public double? Novice { get; set; }

    /// <summary>Gets or sets the intermediate rating boundary.</summary>
    public double? Intermediate { get; set; }

    /// <summary>Gets or sets the advanced rating boundary.</summary>
    public double? Advanced { get; set; }

    /// <summary>Gets or sets the expert rating boundary.</summary>
    public double? Expert { get; set; }
}

/// <summary>
/// Represents the configuration for OpenAI integration.
/// </summary>
public class OpenaiIntegrationConfig
{
    /// <summary>Gets or sets the OpenAI model.</summary>
    public string? Model { get; set; }

    /// <summary>Gets or sets the maximum tokens per request.</summary>
    public double? MaxTokensPerRequest { get; set; }

    /// <summary>Gets or sets the temperature setting.</summary>
    [Range(0, 2, ErrorMessage = "TemperatureSetting must be between 0 and 2.")]
    public double? TemperatureSetting { get; set; }

    /// <summary>Gets or sets the daily budget limit.</summary>
    public double? DailyBudgetLimit { get; set; }

    /// <summary>Gets or sets the monthly budget limit.</summary>
    public double? MonthlyBudgetLimit { get; set; }

    /// <summary>Gets or sets a value indicating whether fallback is enabled.</summary>
    public bool? FallbackEnabled { get; set; }
}

/// <summary>
/// Represents the configuration for tiebreakers.
/// </summary>
public class TiebreakerConfig
{
    /// <summary>Gets or sets the maximum tiebreaker wait time.</summary>
    public string? MaxTiebreakerWaitTime { get; set; }

    /// <summary>Gets or sets the third transcriber priority.</summary>
    public string? ThirdTranscriberPriority { get; set; }

    /// <summary>Gets or sets the tiebreaker Elo bonus.</summary>
    public double? TiebreakerEloBonus { get; set; }
}

/// <summary>
/// Represents the configuration for professional QA.
/// </summary>
public class ProfessionalQaConfig
{
    /// <summary>Gets or sets a value indicating whether spot checks are enabled.</summary>
    public bool? EnableSpotChecks { get; set; }

    /// <summary>Gets or sets the default spot check percentage.</summary>
    public double? DefaultSpotCheckPercentage { get; set; }

    /// <summary>Gets or sets the quality threshold for professionals.</summary>
    public double? QualityThresholdForProfessionals { get; set; }

    /// <summary>Gets or sets a value indicating whether to bypass head-to-head comparison.</summary>
    public bool? BypassHeadToHeadComparison { get; set; }
}
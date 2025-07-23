using SharedLibrary.RequestResponseModels.QA.AdminConfig.SupportingModels;

namespace SharedLibrary.RequestResponseModels.QA.AdminConfig
{
    public class AdminConfigRequest
    {
        public ComparisonWorkflowConfig? ComparisonWorkflowConfig { get; set; }
        public EloCalculationConfig? EloCalculationConfig { get; set; }
        public OpenaiIntegrationConfig? OpenaiIntegrationConfig { get; set; }
        public TieBreakerConfig? TieBreakerConfig { get; set; }
        public ProfessionalQaConfig? ProfessionalQaConfig { get; set; }
    }
}

namespace SharedLibrary.RequestResponseModels.QA.AdminConfig.SupportingModels
{
    public class ComparisonWorkflowConfig
    {
        public bool? OpenaiScoringEnabled { get; set; }
        public double? OpenaiConfidenceThreshold { get; set; }
        public double? TieBreakerThreshold { get; set; }
        public double? SimilarityThreshold { get; set; }
        public bool? AutoProcessingEnabled { get; set; }
    }

    public class EloCalculationConfig
    {
        public KFactors? KFactors { get; set; }
        public RatingBounderies? RatingBoundaries { get; set; }
    }

    public class KFactors
    {
        public double? Novice { get; set; }
        public double? Intermediate { get; set; }
        public double? Advanced { get; set; }
        public double? Expert { get; set; }
    }

    public class RatingBounderies
    {
        public double? Novice { get; set; }
        public double? Intermediate { get; set; }
        public double? Advanced { get; set; }
        public double? Expert { get; set; }
    }

    public class OpenaiIntegrationConfig
    {
        public string? Model { get; set; }
        public double? MaxTokensPerRequest { get; set; }
        public double? TemperatureSetting { get; set; }
        public double? DailyBudgetLimit { get; set; }
        public double? MonthlyBudgetLimit { get; set; }
        public bool? FallbackEnabled { get; set; }
    }

    public class TieBreakerConfig
    {
        public string? MaxTiebreakerWaitTime { get; set; }
        public string? ThirdTranscriberPriority { get; set; }
        public double TiebreakerEloBonus { get; set; }
    }

    public class ProfessionalQaConfig
    {
        public bool? EnableSpotChecks { get; set; }
        public double? DefaultSpotCheckPercentage { get; set; }
        public double? QualityThresholdForProfessionals { get; set; }
        public bool? BypassHeadToHeadComparison { get; set; }
    }
}
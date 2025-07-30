namespace SharedLibrary.RequestResponseModels.QA.ProfessionalSpotCheckConfig;

public class ProfessionalSpotCheckResponse
{
    public required bool SpotCheckConfigUpdated { get; set; }
    public required Configuration Configuration { get; set; }
    public required EstimatedCost EstimatedCost { get; set; }
    public required string EffectiveFrom { get; set; }
}

public class EstimatedCost
{
    public double DailyEstimate { get; set; }
    public double MonthlyEstimate { get; set; }
}

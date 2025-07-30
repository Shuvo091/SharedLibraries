namespace SharedLibrary.RequestResponseModels.QA.ProfessionalSpotCheckConfig;

public class ProfessionalSpotCheckRequest
{
    public Configuration? Configuration { get; set; }
    public ProfessionalFilters? ProfessionalFilters { get; set; }
}

public class Configuration
{
    public double? SpotCheckPercentage { get; set; }
    public double? MinimumSampleSize { get; set; }
    public double? MaxChecksPerDay { get; set; }
    public double? QualityThreshold { get; set; }
    public bool? EnableRandomSampling { get; set; }
}

public class ProfessionalFilters
{
    public double? MinEloRating { get; set; }
    public List<string>? IncludeDialects { get; set; }
    public string? TimeRange { get; set; }
}
namespace SharedLibrary.RequestResponseModels.QA.AdminConfig;

public class AdminConfigPutResponse
{
    public required bool ConfigurationUpdated { get; set; }
    public required string UpdatedAt { get; set; }
    public required List<string> ChangesApplied { get; set; }
    public required bool RestartRequired { get; set; }
    public required List<string> AffectedServices { get; set; }
}

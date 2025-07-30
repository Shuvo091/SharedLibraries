namespace SharedLibrary.RequestResponseModels.QA.AdminConfig;

/// <summary>
/// Represents the response for updating admin configuration.
/// </summary>
public class AdminConfigPutResponse
{
    /// <summary>Gets or sets whether the configuration was updated.</summary>
    public required bool ConfigurationUpdated { get; set; }
    /// <summary>Gets or sets the update timestamp.</summary>
    public required string UpdatedAt { get; set; }
    /// <summary>Gets or sets the list of changes applied.</summary>
    public required List<string> ChangesApplied { get; set; }
    /// <summary>Gets or sets whether a restart is required.</summary>
    public required bool RestartRequired { get; set; }
    /// <summary>Gets or sets the list of affected services.</summary>
    public required List<string> AffectedServices { get; set; }
}

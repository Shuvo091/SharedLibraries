namespace SharedLibrary.RequestResponseModels.QA.AdminConfig;

/// <summary>
/// Represents the response for updating admin configuration.
/// </summary>
public class AdminConfigPutResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether the configuration was updated.
    /// </summary>
    required public bool ConfigurationUpdated { get; set; }

    /// <summary>
    /// Gets or sets the update timestamp.
    /// </summary>
    required public string UpdatedAt { get; set; }

    /// <summary>
    /// Gets or sets the list of changes applied.
    /// </summary>
    required public List<string> ChangesApplied { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a restart is required.
    /// </summary>
    required public bool RestartRequired { get; set; }

    /// <summary>
    /// Gets or sets the list of affected services.
    /// </summary>
    required public List<string> AffectedServices { get; set; }
}
namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents the progress details of an audit, including sample counts and current stage.
/// </summary>
public class AuditProgress
{
    /// <summary>
    /// Gets or sets the total number of samples in the audit.
    /// </summary>
    public int TotalSamples { get; set; }

    /// <summary>
    /// Gets or sets the number of samples that have been processed.
    /// </summary>
    public int ProcessedSamples { get; set; }

    /// <summary>
    /// Gets or sets the current stage of the audit process.
    /// </summary>
    public string CurrentStage { get; set; } = string.Empty;
}

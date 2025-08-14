namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents the cost breakdown for processing the audit.
/// </summary>
public class CostBreakdownDto
{
    /// <summary>
    /// Gets or sets the cost associated with OpenAI processing.
    /// </summary>
    public double OpenaiProcessingCost { get; set; }

    /// <summary>
    /// Gets or sets the cost for storage and compute resources.
    /// </summary>
    public double StorageAndCompute { get; set; }

    /// <summary>
    /// Gets or sets the total cost for the audit.
    /// </summary>
    public double TotalCost { get; set; }
}

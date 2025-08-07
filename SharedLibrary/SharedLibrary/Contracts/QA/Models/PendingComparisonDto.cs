using System.Text.Json.Serialization;
using SharedLibrary.Contracts.QA.Enums;
using SharedLibrary.Contracts.QA.JsonConverters;

namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents the data transfer object for a pending comparison, including its unique identifier, status, stage, and
/// timestamps.
/// </summary>
public class PendingComparisonDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the comparison.
    /// </summary>
    required public Guid ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets the status of the comparison.
    /// </summary>
    [JsonConverter(typeof(ComparisonStatusConverter))]
    required public ComparisonStatus ComparisonStatus { get; set; } = ComparisonStatus.Pending;

    /// <summary>
    /// Gets or sets the current stage of the comparison process.
    /// </summary>
    [JsonConverter(typeof(ComparisonStageConverter))]
    required public ComparisonStage CurrentStage { get; set; } = ComparisonStage.Initial;

    /// <summary>
    /// Gets or sets the creation date and time of the comparison.
    /// </summary>
    required public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the started date and time of the comparison.
    /// </summary>
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// Gets or sets the estimated completion date and time for the operation.
    /// </summary>
    public DateTime? EstimatedCompletion { get; set; }
}

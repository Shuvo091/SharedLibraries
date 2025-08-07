using System.Text.Json.Serialization;
using SharedLibrary.Contracts.QA.Enums;
using SharedLibrary.Contracts.QA.JsonConverters;
using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Result of a comparison operation.
/// </summary>
public class ComparisonResult
{
    /// <summary>
    /// Gets or sets comparison identifier.
    /// </summary>
    required public string ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets reference to the QA service.
    /// </summary>
    required public string QaServiceReference { get; set; }

    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    required public string WorkflowRequestId { get; set; }

    /// <summary>
    /// Gets or sets status of the comparison.
    /// </summary>
    [JsonConverter(typeof(ComparisonStatusConverter))]
    public ComparisonStatus Status { get; set; }

    /// <summary>
    /// Gets or sets assessment result from OpenAI.
    /// </summary>
    public OpenAiResult? OpenAiAssessment { get; set; }

    /// <summary>
    /// Gets or sets list of Elo changes recommended.
    /// </summary>
    public List<EloRecommendation>? EloChanges { get; set; }

    /// <summary>
    /// Gets or sets next action to be taken.
    /// </summary>
    [JsonConverter(typeof(NextActionConverter))]
    public NextAction NextAction { get; set; }
}

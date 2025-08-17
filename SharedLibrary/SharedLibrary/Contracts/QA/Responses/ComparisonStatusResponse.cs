using System.Text.Json.Serialization;
using SharedLibrary.Contracts.QA.Enums;
using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Status response for a comparison.
/// </summary>
public class ComparisonStatusResponse
{
    /// <summary>
    /// Gets or sets comparison identifier.
    /// </summary>
    required public Guid ComparisonId { get; set; }

    /// <summary>
    /// Gets or sets status of the comparison.
    /// </summary>
    public ComparisonStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the current stage of the comparison process.
    /// </summary>
    required public ComparisonStage CurrentStage { get; set; }

    /// <summary>
    /// Gets or sets the outcome of the comparison.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FinalWinner { get; set; }

    /// <summary>
    /// Gets or sets the result of three way analysis.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ThreeWayAnalysis? ThreeWayAnalysis { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the tiebreaker has been resolved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? IsTiebreakerResolved { get; set; }

    /// <summary>
    /// Gets or sets assessment result from OpenAI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAiResult? OpenAiAssessment { get; set; }

    /// <summary>
    /// Gets or sets list of Elo changes recommended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<EloRecommendation>? EloChanges { get; set; }

    /// <summary>
    /// Gets or sets the creation date and time of the comparison.
    /// </summary>
    required public DateTime ComparisonCreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the timestamp indicating when the comparison process started.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? ComparisonStartedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the comparison process was completed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? ComparisonCompletedAt { get; set; }

    /// <summary>
    /// Gets or sets the next action to be taken in the comparison process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public NextAction? NextAction { get; set; }
}

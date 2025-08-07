using System.Text.Json.Serialization;
using SharedLibrary.Contracts.QA.Enums;
using SharedLibrary.Contracts.QA.JsonConverters;
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
    [JsonConverter(typeof(ComparisonStatusConverter))]
    public ComparisonStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the current stage of the comparison process.
    /// </summary>
    [JsonConverter(typeof(ComparisonStageConverter))]
    required public ComparisonStage CurrentStage { get; set; }

    /// <summary>
    /// Gets or sets assessment result from OpenAI.
    /// </summary>
    public OpenAiResult? OpenAiAssessment { get; set; }

    /// <summary>
    /// Gets or sets list of Elo changes recommended.
    /// </summary>
    public List<EloRecommendation>? EloChanges { get; set; }

    /// <summary>
    /// Gets or sets the creation date and time of the comparison.
    /// </summary>
    required public DateTime ComparisonCreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the timestamp indicating when the comparison process started.
    /// </summary>
    public DateTime? ComparisonStartedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the comparison process was completed.
    /// </summary>
    public DateTime? ComparisonCompletedAt { get; set; }
}

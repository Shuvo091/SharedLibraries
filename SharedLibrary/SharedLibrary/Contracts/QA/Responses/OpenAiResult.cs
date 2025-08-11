using System.Text.Json.Serialization;
using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses;

/// <summary>
/// Result of OpenAI assessment.
/// </summary>
public class OpenAiResult
{
    /// <summary>
    /// Gets or sets winner transcription identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Winner { get; set; }

    /// <summary>
    /// Gets or sets similarity score between transcriptions.
    /// </summary>
    required public double SimilarityScore { get; set; }

    /// <summary>
    /// Gets or sets confidence in the assessment.
    /// </summary>
    required public double Confidence { get; set; }

    /// <summary>
    /// Gets or sets linguistic analysis details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LinguisticAnalysis? LinguisticAnalysis { get; set; }

    /// <summary>
    /// Gets or sets reasoning for the assessment.
    /// </summary>
    required public string Reasoning { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if a tiebreaker is needed.
    /// </summary>
    public bool NeedsTieBreaker { get; set; }
}

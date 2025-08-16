namespace SharedLibrary.Contracts.Transcription.Models;

/// <summary>
/// Contains details from an OpenAI assessment of the comparison.
/// </summary>
public class OpenAiAssessment
{
    /// <summary>
    /// Gets or sets The calculated similarity score between the compared items.
    /// </summary>
    public double SimilarityScore { get; set; }

    /// <summary>
    /// Gets or sets The confidence level of the similarity score.
    /// </summary>
    public double Confidence { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a tiebreaker is required.
    /// </summary>
    public bool RequiresTiebreaker { get; set; }
}

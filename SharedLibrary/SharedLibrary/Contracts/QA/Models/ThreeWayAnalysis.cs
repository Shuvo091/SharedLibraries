namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents the result of a three-way analysis in QA, including methodology, transcription alignment, consensus strength, and confidence.
/// </summary>
public class ThreeWayAnalysis
{
    /// <summary>
    /// Gets or sets the methodology used for the three-way analysis.
    /// </summary>
    required public string Methodology { get; set; }

    /// <summary>
    /// Gets or sets the transcription alignment data, mapping keys to lists of aligned transcriptions.
    /// </summary>
    required public Dictionary<string, List<string>> TranscriptionAlignment { get; set; }

    /// <summary>
    /// Gets or sets the strength of the consensus reached in the analysis.
    /// </summary>
    required public string ConsensusStrength { get; set; }

    /// <summary>
    /// Gets or sets the confidence score of the analysis.
    /// </summary>
    required public double Confidence { get; set; }
}

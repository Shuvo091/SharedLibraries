namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Analysis details for a tiebreaker operation.
/// </summary>
public class TieBreakAnalysis
{
    /// <summary>
    /// Gets or sets methodology used for analysis.
    /// </summary>
    required public string Methodology { get; set; }

    /// <summary>
    /// Gets or sets alignment of transcriptions.
    /// </summary>
    required public Dictionary<string, List<string>> TranscriptionAlignment { get; set; }

    /// <summary>
    /// Gets or sets strength of consensus.
    /// </summary>
    required public string ConsensusStrength { get; set; }

    /// <summary>
    /// Gets or sets confidence in the analysis.
    /// </summary>
    required public double Confidence { get; set; }
}

using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Requests;

/// <summary>
/// Request model for a comparison operation.
/// </summary>
public class ComparisonRequest
{
    /// <summary>
    /// Gets or sets workflow request identifier.
    /// </summary>
    required public Guid WorkflowRequestId { get; set; }

    /// <summary>
    /// Gets or sets job identifier.
    /// </summary>
    required public Guid JodId { get; set; }

    /// <summary>
    /// Gets or sets audio segment identifier.
    /// </summary>
    required public string AudioSegmentId { get; set; }

    /// <summary>
    /// Gets or sets original audio data.
    /// </summary>
    required public string OriginalAudio { get; set; }

    /// <summary>
    /// Gets or sets list of transcriptions to compare.
    /// </summary>
    required public List<Transcription> Transcriptions { get; set; }

    /// <summary>
    /// Gets or sets dialect of the audio.
    /// </summary>
    required public string Dialect { get; set; }

    /// <summary>
    /// Gets or sets priority of the comparison.
    /// </summary>
    required public string Priority { get; set; }
}

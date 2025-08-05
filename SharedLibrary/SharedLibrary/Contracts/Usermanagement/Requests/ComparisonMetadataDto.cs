using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Metadata about a QA comparison.
/// </summary>
public class ComparisonMetadataDto
{
    /// <summary>
    /// Gets or sets audio segment identifier.
    /// </summary>
    [Required(ErrorMessage = "AudioSegmentId is required.")]
    public string? AudioSegmentId { get; set; }

    /// <summary>
    /// Gets or sets type of comparison performed.
    /// </summary>
    [Required(ErrorMessage = "ComparisonType is required.")]
    public string? ComparisonType { get; set; }

    /// <summary>
    /// Gets or sets confidence score from QA (0 to 1).
    /// </summary>
    [Range(0, 1, ErrorMessage = "QaConfidence must be between 0 and 1.")]
    public double QaConfidence { get; set; }

    /// <summary>
    /// Gets or sets qA method used.
    /// </summary>
    [Required(ErrorMessage = "QaMethod is required.")]
    public string? QaMethod { get; set; }

    /// <summary>
    /// Gets or sets timestamp of the comparison.
    /// </summary>
    [Required(ErrorMessage = "ComparisonTimestamp is required.")]
    public DateTime ComparisonTimestamp { get; set; }
}
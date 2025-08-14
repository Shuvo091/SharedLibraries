namespace SharedLibrary.Contracts.Transcription.Requests;

/// <summary>
/// Represents the dialect configuration used in a quality check.
/// </summary>
public class DialectConfig
{
    /// <summary>
    /// Gets or sets the primary language to check against (e.g., "afrikaans").
    /// </summary>
    public string Language { get; set; } = default!;

    /// <summary>
    /// Gets or sets the dialect variant of the language (e.g., "western_cape").
    /// </summary>
    public string Variant { get; set; } = default!;

    /// <summary>
    /// Gets or sets the custom dictionary name or identifier.
    /// used to supplement the quality check (e.g., "solidariteit_terms").
    /// </summary>
    public string CustomDictionary { get; set; } = default!;
}

namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Data transfer object for validation result details.
/// </summary>
public class ValidationResultDto
{
    /// <summary>
    /// Gets or sets a value indicating whether the ID format is valid.
    /// </summary>
    public bool IdFormatValid { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a photo is present.
    /// </summary>
    public bool PhotoPresent { get; set; }

    /// <summary>
    /// Gets or sets an optional note about the validation.
    /// </summary>
    public string? Note { get; set; }
}

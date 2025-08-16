using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Data transfer object for ID document validation.
/// </summary>
public class IdDocumentValidationDto
{
    /// <summary>
    /// Gets or sets a value indicating whether validation is enabled.
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// Gets or sets the ID number to validate.
    /// </summary>
    [Required(ErrorMessage = "IdNumber is required when validation is enabled.")]
    [MinLength(1, ErrorMessage = "IdNumber cannot be empty.")]
    public string IdNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether a photo was uploaded.
    /// </summary>
    public bool PhotoUploaded { get; set; }

    /// <summary>
    /// Gets or sets the validation result details.
    /// </summary>
    [Required(ErrorMessage = "ValidationResult is required.")]
    public ValidationResultDto ValidationResult { get; set; } = new ValidationResultDto();
}

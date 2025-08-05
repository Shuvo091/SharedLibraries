using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Request to register a new user.
/// </summary>
public class UserRegisterRequest
{
    /// <summary>
    /// Gets or sets user's email address.
    /// </summary>
    [Required]
    [EmailAddress]
    public string Email { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's password (minimum 6 characters).
    /// </summary>
    [Required]
    [MinLength(6)]
    public string Password { get; set; } = default!; // Local login required

    /// <summary>
    /// Gets or sets user's first name.
    /// </summary>
    [Required]
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's last name.
    /// </summary>
    [Required]
    public string LastName { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's identification number (optional).
    /// </summary>
    public string? IdNumber { get; set; } // Optional due to regulation

    /// <summary>
    /// Gets or sets user's phone number (optional).
    /// </summary>
    public string? Phone { get; set; } // Optional due to regulation

    /// <summary>
    /// Gets or sets list of user's dialect preferences.
    /// </summary>
    public List<string>? DialectPreferences { get; set; } = [];

    /// <summary>
    /// Gets or sets user's language experience (optional).
    /// </summary>
    public string? LanguageExperience { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user consents to data processing (POPIA compliance).
    /// </summary>
    public bool ConsentToDataProcessing { get; set; } // For POPIA compliance
}
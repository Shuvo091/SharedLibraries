using System.ComponentModel.DataAnnotations;
using SharedLibrary.AppEnums;

namespace SharedLibrary.RequestResponseModels.UserManagement;

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

/// <summary>
/// Response after registering a new user.
/// </summary>
public class UserRegisterResponse
{
    /// <summary>
    /// Gets or sets unique identifier for the registered user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user's initial Elo rating.
    /// </summary>
    public int EloRating { get; set; }

    /// <summary>
    /// Gets or sets status of the user after registration.
    /// </summary>
    public string Status { get; set; } = UserStatusType.PendingVerification.ToDisplayName();

    /// <summary>
    /// Gets or sets uRI to the user's profile.
    /// </summary>
    public string ProfileUri { get; set; } = default!;

    /// <summary>
    /// Gets or sets list of verification requirements for the user.
    /// </summary>
    public List<string> VerificationRequired { get; set; } = [VerificationType.IdDocument.ToDisplayName()];
}
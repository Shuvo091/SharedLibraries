using SharedLibrary.AppEnums;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region User Registration Request

public class UserRegisterRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = default!;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = default!; // Local login required

    [Required]
    public string FirstName { get; set; } = default!;

    [Required]
    public string LastName { get; set; } = default!;

    public string? IdNumber { get; set; } // Optional due to regulation

    public string? Phone { get; set; } // Optional due to regulation

    public List<string>? DialectPreferences { get; set; } = [];

    public string? LanguageExperience { get; set; } = default!;

    public bool ConsentToDataProcessing { get; set; } // For POPIA compliance
}

#endregion

#region User Registration Response

public class UserRegisterResponse
{
    public Guid UserId { get; set; }
    public int EloRating { get; set; }
    public string Status { get; set; } = UserStatusType.PendingVerification.ToDisplayName();
    public string ProfileUri { get; set; } = default!;
    public List<string> VerificationRequired { get; set; } = [VerificationType.IdDocument.ToDisplayName()];
}

#endregion
using SharedLibrary.AppEnums;
using SharedLibrary.Common.Utilities;

namespace SharedLibrary.Contracts.Usermanagement.Responses;

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
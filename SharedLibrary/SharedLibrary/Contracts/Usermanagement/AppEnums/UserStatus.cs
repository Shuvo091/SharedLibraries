using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.AppEnums;

/// <summary>
/// Specifies the status of a user in the system.
/// </summary>
public enum UserStatusType
{
    /// <summary>
    /// The user is pending verification.
    /// </summary>
    [Display(Name = "pending_verification")]
    PendingVerification,

    /// <summary>
    /// The user is active.
    /// </summary>
    [Display(Name = "active")]
    Active,
}
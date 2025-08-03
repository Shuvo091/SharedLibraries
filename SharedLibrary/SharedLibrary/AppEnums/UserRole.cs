using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

/// <summary>
/// Specifies the role of a user in the system.
/// </summary>
public enum UserRoleType
{
    /// <summary>
    /// The user is a transcriber.
    /// </summary>
    [Display(Name = "Transcriber")]
    Transcriber,

    /// <summary>
    /// The user is a professional.
    /// </summary>
    [Display(Name = "Professional")]
    Professional,

    /// <summary>
    /// The user is a QA reviewer.
    /// </summary>
    [Display(Name = "QAReviewer")]
    QAReviewer,

    /// <summary>
    /// The user is an administrator.
    /// </summary>
    [Display(Name = "Admin")]
    Admin,
}
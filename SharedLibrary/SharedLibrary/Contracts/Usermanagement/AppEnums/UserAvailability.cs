using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

/// <summary>
/// Specifies the availability status of a user.
/// </summary>
public enum UserAvailabilityType
{
    /// <summary>
    /// The user is available.
    /// </summary>
    [Display(Name = "available")]
    Available,

    /// <summary>
    /// The user is busy.
    /// </summary>
    [Display(Name = "busy")]
    Busy,

    /// <summary>
    /// The user is offline.
    /// </summary>
    [Display(Name = "offline")]
    Offline,

    /// <summary>
    /// The user is on leave.
    /// </summary>
    [Display(Name = "leave")]
    Leave,
}
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum UserAvailabilityType
{
    [Display(Name = "available")]
    Available,

    [Display(Name = "busy")]
    Busy,

    [Display(Name = "offline")]
    Offline,

    [Display(Name = "leave")]
    Leave
}

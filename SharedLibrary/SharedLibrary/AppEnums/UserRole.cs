using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum UserRoleType
{
    [Display(Name = "Transcriber")]
    Transcriber,

    [Display(Name = "Professional")]
    Professional,

    [Display(Name = "QAReviewer")]
    QAReviewer,

    [Display(Name = "Admin")]
    Admin
}

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum VerificationStatusType
{
    [Display(Name = "approved")]
    Approved,

    [Display(Name = "rejected")]
    Rejected,
}

public enum VerificationLevelType
{
    [Display(Name = "basic_v1")]
    BasicV1,

    [Display(Name = "strict_v2")]
    StrictV2
}
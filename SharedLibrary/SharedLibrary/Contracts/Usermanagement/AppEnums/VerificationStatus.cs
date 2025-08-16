using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.AppEnums;

/// <summary>
/// Specifies the verification status of a user or entity.
/// </summary>
public enum VerificationStatusType
{
    /// <summary>
    /// The verification is approved.
    /// </summary>
    [Display(Name = "approved")]
    Approved,

    /// <summary>
    /// The verification is rejected.
    /// </summary>
    [Display(Name = "rejected")]
    Rejected,
}

/// <summary>
/// Specifies the verification level of a user or entity.
/// </summary>
public enum VerificationLevelType
{
    /// <summary>
    /// Basic verification level (v1).
    /// </summary>
    [Display(Name = "basic_v1")]
    BasicV1,

    /// <summary>
    /// Strict verification level (v2).
    /// </summary>
    [Display(Name = "strict_v2")]
    StrictV2,
}
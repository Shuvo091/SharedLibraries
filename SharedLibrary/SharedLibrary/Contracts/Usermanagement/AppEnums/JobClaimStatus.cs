using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.AppEnums;

/// <summary>
/// Specifies the status of a job claim.
/// </summary>
public enum JobClaimStatus
{
    /// <summary>
    /// The job claim is pending.
    /// </summary>
    [Display(Name = "pending")]
    Pending,

    /// <summary>
    /// The job claim is completed.
    /// </summary>
    [Display(Name = "completed")]
    Completed,

    /// <summary>
    /// The job claim has failed.
    /// </summary>
    [Display(Name = "failed")]
    Failed,

    /// <summary>
    /// The job claim assigned.
    /// </summary>
    [Display(Name = "assigned")]
    Assigned,
}
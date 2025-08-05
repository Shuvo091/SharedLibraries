using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents the status of a comparison.
/// </summary>
public enum ComparisonStatus
{
    /// <summary>
    /// Indicates the comparison is pending.
    /// </summary>
    [Display(Name = "pending")]
    Pending = 0,

    /// <summary>
    /// Indicates the comparison is in progress.
    /// </summary>
    [Display(Name = "in_progress")]
    InProgress = 1,

    /// <summary>
    /// Indicates the comparison is completed.
    /// </summary>
    [Display(Name = "completed")]
    Completed = 2,

    /// <summary>
    /// Indicates a tiebreaker is required for the comparison.
    /// </summary>
    [Display(Name = "tiebreaker_required")]
    TieBreakerRequired = 3,

    /// <summary>
    /// Indicates professional bypassed.
    /// </summary>
    [Display(Name = "bypassed_professional")]
    Bypassed_Professional = 4,
}
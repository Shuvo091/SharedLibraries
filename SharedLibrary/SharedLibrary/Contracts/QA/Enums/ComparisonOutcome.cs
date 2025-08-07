using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents the outcome of a comparison for a participant.
/// </summary>
public enum ComparisonOutcome
{
    /// <summary>
    /// Indicates that the outcome is undecided or not yet determined.
    /// </summary>
    [Display(Name = "undecided")]
    Undecided = -1,

    /// <summary>
    /// Indicates a loss outcome.
    /// </summary>
    [Display(Name = "loss")]
    Loss = 0,

    /// <summary>
    /// Indicates a win outcome.
    /// </summary>
    [Display(Name = "win")]
    Win = 1,

    /// <summary>
    /// Indicates a draw outcome.
    /// </summary>
    [Display(Name = "draw")]
    Draw = 2,
}
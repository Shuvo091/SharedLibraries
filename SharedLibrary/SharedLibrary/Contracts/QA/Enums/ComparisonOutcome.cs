using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharedLibrary.Common.Utilities;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents the outcome of a comparison for a participant.
/// </summary>
[JsonConverter(typeof(EnumConverter<ComparisonOutcome>))]
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

    /// <summary>
    /// Indicates a majority winner outcome,
    /// where the participant has won by a majority vote or decision.
    /// </summary>
    [Display(Name = "majority_winner")]
    Majority_Winner = 3,

    /// <summary>
    /// Indicates a minority winner outcome,
    /// where the participant has won by a minority vote or decision.
    /// </summary>
    [Display(Name = "minority_loser")]
    Minority_Loser = 4,
}
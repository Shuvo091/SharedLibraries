using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

/// <summary>
/// Specifies the possible outcomes of a game.
/// </summary>
public enum GameOutcomeType
{
    /// <summary>
    /// The player or team won the game.
    /// </summary>
    [Display(Name = "win")]
    Win,

    /// <summary>
    /// The player or team lost the game.
    /// </summary>
    [Display(Name = "loss")]
    Loss,

    /// <summary>
    /// The game ended in a draw.
    /// </summary>
    [Display(Name = "draw")]
    Draw,

    /// <summary>
    /// The player or team was the minority winner in a three-way game.
    /// </summary>
    [Display(Name = "minority_winner")]
    MinorityWinner,

    /// <summary>
    /// The player or team was the majority winner in a three-way game.
    /// </summary>
    [Display(Name = "majority_winner")]
    MajorityWinner,

    /// <summary>
    /// The player or team was the minority loser in a three-way game.
    /// </summary>
    [Display(Name = "minority_loser")]
    MinorityLoser,

    /// <summary>
    /// The player or team was the majority loser in a three-way game.
    /// </summary>
    [Display(Name = "majority_loser")]
    MajorityLoser,
}
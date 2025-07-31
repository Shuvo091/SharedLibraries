using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum GameOutcomeType
{
    [Display(Name = "win")]
    Win,

    [Display(Name = "loss")]
    Loss,

    [Display(Name = "draw")]
    Draw,

    // For Three way
    [Display(Name = "minority_winner")]
    MinorityWinner,

    [Display(Name = "majority_winner")]
    MajorityWinner,

    [Display(Name = "minority_loser")]
    MinorityLoser,

    [Display(Name = "majority_loser")]
    MajorityLoser,

}
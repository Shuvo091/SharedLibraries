using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum GameOutcomeType
{
	[Display(Name = "win")]
	Win,

	[Display(Name = "loss")]
	Loss,

	[Display(Name = "draw")]
	Draw
}
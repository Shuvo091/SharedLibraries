using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum JobClaimStatus
{
	[Display(Name = "pending")]
	Pending,

	[Display(Name = "completed")]
	Completed,

	[Display(Name = "failed")]
	Failed
}
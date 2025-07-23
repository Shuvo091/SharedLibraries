using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum UserStatusType
{
	[Display(Name = "pending_verification")]
	PendingVerification,

	[Display(Name = "active")]
	Active
}

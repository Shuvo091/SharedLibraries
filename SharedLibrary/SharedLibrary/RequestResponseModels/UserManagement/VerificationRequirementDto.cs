using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.RequestResponseModels.UserManagement;

#region Verification Requirement Request

public class UpdateVerificationRequirementsRequest
{
	public bool RequireIdDocument { get; set; }
	public bool RequirePhotoUpload { get; set; }
	public bool RequirePhoneVerification { get; set; }
	public bool RequireEmailVerification { get; set; }

	[Required(ErrorMessage = "VerificationLevel is required.")]
	[MinLength(1, ErrorMessage = "VerificationLevel cannot be empty.")]
	public string VerificationLevel { get; set; } = string.Empty;

	[Required(ErrorMessage = "ValidationRules dictionary is required.")]
	[MinLength(1, ErrorMessage = "ValidationRules must contain at least one rule.")]
	public Dictionary<string, string> ValidationRules { get; set; } = new();

	[Required(ErrorMessage = "Reason is required.")]
	[MinLength(1, ErrorMessage = "Reason cannot be empty.")]
	public string Reason { get; set; } = string.Empty;
}

#endregion

#region Verification Requirement Response

public class UpdateVerificationRequirementsResponse
{
    public bool RequirementsUpdated { get; set; }
    public bool PiiDataCollection { get; set; }
    public string ComplianceMode { get; set; } = default!;
    public string VerificationLevel { get; set; } = default!;
    public List<string> VerificationSteps { get; set; } = [];
    public Dictionary<string, string> RoadmapEnhancements { get; set; } = [];
}

#endregion
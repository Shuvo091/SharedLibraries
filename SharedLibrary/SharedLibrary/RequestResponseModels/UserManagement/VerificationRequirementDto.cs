using System;
using System.Collections.Generic;
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
    public string VerificationLevel { get; set; } = default!;
    public Dictionary<string, string> ValidationRules { get; set; } = [];
    public string Reason { get; set; } = default!;
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
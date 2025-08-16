using SharedLibrary.Contracts.Usermanagement.Models;

namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response containing professional status information for a batch of users.
/// </summary>
public class ProfessionalStatusBatchResponse
{
    /// <summary>
    /// Gets or sets dictionary mapping user identifiers to their professional status.
    /// </summary>
    public Dictionary<string, ProfessionalStatus> ProfessionalStatuses { get; set; } = new Dictionary<string, ProfessionalStatus>();

    /// <summary>
    /// Gets or sets summary of professional status statistics.
    /// </summary>
    public ProfessionalSummary Summary { get; set; } = new ProfessionalSummary();
}

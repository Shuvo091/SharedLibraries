namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Data transfer object for additional verification options.
/// </summary>
public class AdditionalVerificationDto
{
    /// <summary>
    /// Gets or sets a value indicating whether phone verification is required.
    /// </summary>
    public bool PhoneVerification { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether email verification is required.
    /// </summary>
    public bool EmailVerification { get; set; }
}
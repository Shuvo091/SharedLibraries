namespace SharedLibrary.Contracts.Usermanagement.Requests;

/// <summary>
/// Request object for changing password.
/// </summary>
public class ChangePasswordRequest
{
    /// <summary>
    /// Gets or sets the current password.
    /// </summary>
    public string CurrentPassword { get; set; } = default!;

    /// <summary>
    /// Gets or sets the new password.
    /// </summary>
    public string NewPassword { get; set; } = default!;
}

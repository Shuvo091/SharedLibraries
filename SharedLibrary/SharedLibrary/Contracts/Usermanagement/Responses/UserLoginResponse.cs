namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// User log in request.
/// </summary>
public class UserLoginRequest
{
    /// <summary>
    /// Gets or sets username.
    /// </summary>
    public string Username { get; set; } = default!;

    /// <summary>
    /// Gets or sets password.
    /// </summary>
    public string Password { get; set; } = default!;
}
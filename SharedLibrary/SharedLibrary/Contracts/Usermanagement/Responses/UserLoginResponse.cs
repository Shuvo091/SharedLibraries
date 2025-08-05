namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// User login response.
/// </summary>
public class UserLoginResponse
{
    /// <summary>
    /// Gets or sets accesstoken.
    /// </summary>
    public string AccessToken { get; set; } = default!;

    /// <summary>
    /// Gets or sets expires at.
    /// </summary>
    public DateTime ExpiresAt { get; set; }
}
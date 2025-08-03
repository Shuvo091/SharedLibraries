using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.RequestResponseModels.UserManagement;

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
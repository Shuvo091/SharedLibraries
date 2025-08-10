namespace SharedLibrary.Common.Options;

/// <summary>
/// Jwt Options from config.
/// </summary>
public class JwtOptions
{
    /// <summary>
    /// Gets or sets client secret for jwt validation.
    /// </summary>
    public string Secret { get; set; } = default!;

    /// <summary>
    /// Gets or sets issuer for JWT.
    /// </summary>
    public string Issuer { get; set; } = default!;

    /// <summary>
    /// Gets or sets Expiry minutes.
    /// </summary>
    public int ExpiryMinutes { get; set; }
}
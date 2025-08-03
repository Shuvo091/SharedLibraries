namespace SharedLibrary.Common.Security;

/// <summary>
/// Password hasher helper.
/// </summary>
public static class PasswordHasher
{
    /// <summary>
    /// Hashes password.
    /// </summary>
    /// <param name="password"> password input.</param>
    /// <returns> hashed str.</returns>
    public static string Hash(string password) => BCrypt.Net.BCrypt.HashPassword(password);

    /// <summary>
    /// Verifies password.
    /// </summary>
    /// <param name="password"> password to check. </param>
    /// <param name="hashed">hashed from db. </param>
    /// <returns> verified or not. </returns>
    public static bool Verify(string password, string hashed) => BCrypt.Net.BCrypt.Verify(password, hashed);
}

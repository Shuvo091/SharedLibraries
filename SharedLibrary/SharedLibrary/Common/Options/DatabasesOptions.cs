namespace SharedLibrary.Common.Options;

/// <summary>
/// Represents configuration options for database connections.
/// </summary>
public class DatabasesOptions
{
    /// <summary>
    /// Gets or sets the connection string for the PostgreSQL database.
    /// </summary>
    public string PostgreSQLConnectionString { get; set; } = string.Empty;
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using SharedLibrary.Cache.Models;
using SharedLibrary.Common.Options;

namespace SharedLibrary.Common.Extensions;

/// <summary>
/// Extension methods for adding health checks to the service collection.
/// </summary>
public static class HealthCheckExtensions
{
    /// <summary>
    /// Adds health check services to the specified <see cref="IServiceCollection"/> and configures them based on the
    /// provided <see cref="IConfiguration"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to which the health check services will be added.</param>
    /// <param name="configuration">The <see cref="IConfiguration"/> instance containing health check configuration settings.</param>
    /// <returns>The updated <see cref="IServiceCollection"/> with health check services added.</returns>
    public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services, IConfiguration configuration)
    {
        var postgreSqlConnectionString = configuration.GetSection(nameof(DatabasesOptions)).Get<DatabasesOptions>()?.PostgreSQLConnectionString;
        if (string.IsNullOrEmpty(postgreSqlConnectionString))
        {
            throw new InvalidOperationException("PostgreSQL connection string is not configured.");
        }

        var redisConnectionString = configuration.GetSection(nameof(RedisConfiguration)).Get<RedisConfiguration>()?.ConnectionString;
        if (string.IsNullOrEmpty(redisConnectionString))
        {
            throw new InvalidOperationException("Redis connection string is not configured.");
        }

        services.AddHealthChecks()
            .AddNpgSql(
                connectionString: postgreSqlConnectionString,
                name: "postgresql",
                healthQuery: "SELECT 1;",
                failureStatus: HealthStatus.Unhealthy,
                tags: new[] { "db", "sql" })

            .AddRedis(
                redisConnectionString: redisConnectionString,
                name: "redis",
                failureStatus: HealthStatus.Unhealthy,
                tags: new[] { "cache", "redis" });

        return services;
    }
}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SharedLibrary.Cache.Models;
using SharedLibrary.Cache.Services;
using SharedLibrary.Cache.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Cache.ServiceCollectionExtensions
{
    /// <summary>
    /// Extension methods for IServiceCollection to configure Redis caching
    /// </summary>
    public static class RedisServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Redis caching services to the service collection
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="configuration">The configuration instance</param>
        /// <param name="sectionName">The configuration section name (default: "Redis")</param>
        /// <returns>The service collection for chaining</returns>
        public static IServiceCollection AddRedisCache(
            this IServiceCollection services,
            IConfiguration configuration,
            string sectionName = "Redis")
        {
            var redisConfig = configuration.GetSection(sectionName).Get<RedisConfiguration>();

            if (redisConfig == null)
                throw new InvalidOperationException($"Redis configuration section '{sectionName}' not found or invalid.");

            services.AddSingleton<IConnectionMultiplexer>(provider =>
            {
                var logger = provider.GetRequiredService<ILogger<RedisCacheService>>();
                return RedisConnectionFactory.GetConnection(redisConfig, logger);
            });

            services.AddSingleton<ICacheService>(provider =>
            {
                var connection = provider.GetRequiredService<IConnectionMultiplexer>();
                return new RedisCacheService(connection, redisConfig.DatabaseId);
            });

            return services;
        }
    }
}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SharedLibrary.Cache.Models;
using SharedLibrary.Cache.Services;
using SharedLibrary.Cache.Services.Interfaces;
using SharedLibrary.Redis.Services;
using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Cache.ServiceCollectionExtensions
{
    /// <summary>
    /// Extension methods for IServiceCollection to configure Redis caching
    /// </summary>
    public static class RedisServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Redis necessaries to the service collection.
        /// </summary>
        public static IServiceCollection AddRedis(
            this IServiceCollection services,
            IConfiguration configuration,
            string sectionName = "Redis")
        {
            var redisConfig = configuration.GetSection(sectionName).Get<RedisConfiguration>()
                ?? throw new InvalidOperationException($"Redis configuration section '{sectionName}' not found or invalid.");

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = redisConfig.ConnectionString;
            });

            services.AddSingleton<IConnectionMultiplexer>(provider =>
            {
                var logger = provider.GetRequiredService<ILogger<CacheService>>();
                return RedisConnectionFactory.GetConnection(redisConfig, logger);
            });

            return services;
        }

        /// <summary>
        /// Adds Redis caching services to the service collection.
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <returns>The service collection for chaining</returns>
        public static IServiceCollection AddRedisCache(this IServiceCollection services)
        {
            services.AddSingleton<ICacheService, CacheService>();

            return services;
        }

        /// <summary>
        /// Adds a Redis-based queue service to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to which the Redis queue service will be added.</param>
        /// <param name="configuration">The application configuration containing the Redis settings.</param>
        /// <param name="sectionName">The name of the configuration section that contains the Redis settings.  Defaults to "Redis".</param>
        /// <returns>The updated <see cref="IServiceCollection"/> with the Redis queue service registered.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the specified configuration section is not found or is invalid.</exception>
        public static IServiceCollection AddRedisQueue(
            this IServiceCollection services,
            IConfiguration configuration,
            string sectionName = "Redis")
        {
            var redisConfig = configuration.GetSection(sectionName).Get<RedisConfiguration>()
                ?? throw new InvalidOperationException($"Redis configuration section '{sectionName}' not found or invalid.");

            services.AddSingleton<IDistributedQueue>(provider =>
            {
                var connection = provider.GetRequiredService<IConnectionMultiplexer>();
                return new RedisDistributedQueue(connection, redisConfig.DatabaseId);
            });

            services.AddSingleton<IQueueService, QueueService>();

            return services;
        }
    }
}
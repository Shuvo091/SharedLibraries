using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SharedLibrary.Redis.Models;
using SharedLibrary.Redis.Services;
using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Redis.ServiceCollectionExtensions
{
    /// <summary>
    /// Extension methods for IServiceCollection to configure Redis caching.
    /// </summary>
    public static class RedisServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Redis necessaries to the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to which the Redis service will be added.</param>
        /// <param name="configuration">The application configuration containing the Redis settings.</param>
        /// <param name="sectionName">The name of the configuration section that contains the Redis settings.  Defaults to "Redis".</param>
        /// <returns>The service collection for chaining.</returns>
        public static IServiceCollection AddRedis(
            this IServiceCollection services,
            IConfiguration configuration,
            string sectionName = nameof(RedisConfiguration))
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
        /// <param name="services">The service collection.</param>
        /// <returns>The service collection for chaining.</returns>
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
            string sectionName = nameof(RedisConfiguration))
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

        /// <summary>
        /// Adds a Redis counter service to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to which the Redis counter service will be added.</param>
        /// <param name="configuration">The application configuration containing the Redis settings.</param>
        /// <param name="sectionName">The name of the configuration section that contains the Redis settings.  Defaults to "Redis".</param>
        /// <returns>The updated <see cref="IServiceCollection"/> with the Redis counter service registered.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the specified configuration section is not found or is invalid.</exception>
        public static IServiceCollection AddRedisCounter(
            this IServiceCollection services,
            IConfiguration configuration,
            string sectionName = nameof(RedisConfiguration))
        {
            var redisConfig = configuration.GetSection(sectionName).Get<RedisConfiguration>()
                ?? throw new InvalidOperationException($"Redis configuration section '{sectionName}' not found or invalid.");

            services.AddSingleton<ICounterService>(provider =>
            {
                var connection = provider.GetRequiredService<IConnectionMultiplexer>();
                return new CounterService(connection, redisConfig.DatabaseId);
            });

            return services;
        }

        /// <summary>
        /// Adds a Redis-based priority queue service to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to which the Redis priority queue service will be added.</param>
        /// <param name="configuration">The application configuration containing the Redis settings.</param>
        /// <param name="sectionName">The name of the configuration section that contains the Redis settings.  Defaults to "Redis".</param>
        /// <returns>The updated <see cref="IServiceCollection"/> with the Redis priority queue service registered.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the specified configuration section is not found or is invalid.</exception>
        public static IServiceCollection AddRedisPriorityQueue(
            this IServiceCollection services,
            IConfiguration configuration,
            string sectionName = nameof(RedisConfiguration))
        {
            var redisConfig = configuration.GetSection(sectionName).Get<RedisConfiguration>()
                ?? throw new InvalidOperationException($"Redis configuration section '{sectionName}' not found or invalid.");

            services.AddSingleton<IPriorityQueueService>(provider =>
            {
                var connection = provider.GetRequiredService<IConnectionMultiplexer>();
                return new PriorityQueueService(connection, redisConfig.DatabaseId);
            });

            return services;
        }
    }
}
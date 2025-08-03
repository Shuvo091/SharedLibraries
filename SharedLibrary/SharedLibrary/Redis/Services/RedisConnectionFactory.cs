using Microsoft.Extensions.Logging;
using SharedLibrary.Cache.Models;
using StackExchange.Redis;

namespace SharedLibrary.Cache.Services
{
    /// <summary>
    /// Factory class for creating and managing Redis connections.
    /// </summary>
    public static class RedisConnectionFactory
    {
        private static readonly object Lock = new object();
        private static IConnectionMultiplexer? connection;

        /// <summary>
        /// Gets or creates a Redis connection with the specified configuration.
        /// </summary>
        /// <param name="redisConfiguration">Redis configuration object.</param>
        /// <param name="logger">Logger instance.</param>
        /// <returns>Redis connection multiplexer.</returns>
        public static IConnectionMultiplexer GetConnection(RedisConfiguration redisConfiguration, ILogger logger)
        {
            if (connection != null && connection.IsConnected)
            {
                return connection;
            }

            lock (Lock)
            {
                if (connection != null && connection.IsConnected)
                {
                    return connection;
                }

                var options = ConfigurationOptions.Parse(redisConfiguration.ConnectionString);
                options.ConnectRetry = redisConfiguration.ConnectRetry;
                options.ReconnectRetryPolicy = new ExponentialRetry(redisConfiguration.ReconnectRetryPolicy);
                options.ConnectTimeout = redisConfiguration.ConnectTimeout;
                options.SyncTimeout = redisConfiguration.SyncTimeout;

                connection = ConnectionMultiplexer.Connect(options);

                connection.ConnectionFailed += (sender, e) =>
                {
                    logger.LogError(e.Exception, "Redis connection failed: {Message}", e.Exception?.Message);
                };

                connection.ConnectionRestored += (sender, e) =>
                {
                    logger.LogInformation("Redis connection restored");
                };

                return connection;
            }
        }

        /// <summary>
        /// Disposes the current Redis connection.
        /// </summary>
        public static void DisposeConnection()
        {
            lock (Lock)
            {
                connection?.Close();
                connection?.Dispose();
                connection = null;
            }
        }
    }
}
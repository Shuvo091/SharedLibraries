using Microsoft.Extensions.Logging;
using SharedLibrary.Cache.Models;
using StackExchange.Redis;

namespace SharedLibrary.Cache.Services
{
    /// <summary>
    /// Factory class for creating and managing Redis connections
    /// </summary>
    public static class RedisConnectionFactory
    {
        private static IConnectionMultiplexer? _connection;
        private static readonly object _lock = new object();

        /// <summary>
        /// Gets or creates a Redis connection with the specified configuration
        /// </summary>
        /// <param name="redisConfiguration">Redis configuration object</param>
        /// <param name="logger">Logger instance</param>
        /// <returns>Redis connection multiplexer</returns>
        public static IConnectionMultiplexer GetConnection(RedisConfiguration redisConfiguration, ILogger logger)
        {
            if (_connection != null && _connection.IsConnected)
                return _connection;

            lock (_lock)
            {
                if (_connection != null && _connection.IsConnected)
                    return _connection;

                var options = ConfigurationOptions.Parse(redisConfiguration.ConnectionString);
                options.ConnectRetry = redisConfiguration.ConnectRetry;
                options.ReconnectRetryPolicy = new ExponentialRetry(redisConfiguration.ReconnectRetryPolicy);
                options.ConnectTimeout = redisConfiguration.ConnectTimeout;
                options.SyncTimeout = redisConfiguration.SyncTimeout;

                _connection = ConnectionMultiplexer.Connect(options);

                _connection.ConnectionFailed += (sender, e) =>
                {
                    logger.LogError(e.Exception, "Redis connection failed: {Message}", e.Exception?.Message);
                };

                _connection.ConnectionRestored += (sender, e) =>
                {
                    logger.LogInformation("Redis connection restored");
                };

                return _connection;
            }
        }

        /// <summary>
        /// Disposes the current Redis connection
        /// </summary>
        public static void DisposeConnection()
        {
            lock (_lock)
            {
                _connection?.Close();
                _connection?.Dispose();
                _connection = null;
            }
        }
    }
}
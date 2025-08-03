namespace SharedLibrary.Cache.Models
{
    /// <summary>
    /// Configuration model for Redis connection settings.
    /// </summary>
    public class RedisConfiguration
    {
        /// <summary>
        /// Gets or sets redis connection string.
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets redis database ID (default: 0).
        /// </summary>
        public int DatabaseId { get; set; } = 0;

        /// <summary>
        /// Gets or sets connection timeout in milliseconds (default: 60000).
        /// </summary>
        public int ConnectTimeout { get; set; } = 60000;

        /// <summary>
        /// Gets or sets sync timeout in milliseconds (default: 60000).
        /// </summary>
        public int SyncTimeout { get; set; } = 60000;

        /// <summary>
        /// Gets or sets number of connection retries (default: 3).
        /// </summary>
        public int ConnectRetry { get; set; } = 3;

        /// <summary>
        /// Gets or sets number of reconnection retry policy (default: 3).
        /// </summary>
        public int ReconnectRetryPolicy { get; set; } = 3;
    }
}
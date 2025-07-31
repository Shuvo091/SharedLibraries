namespace SharedLibrary.Cache.Models
{
    /// <summary>
    /// Configuration model for Redis connection settings
    /// </summary>
    public class RedisConfiguration
    {
        /// <summary>
        /// Redis connection string
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// Redis database ID (default: 0)
        /// </summary>
        public int DatabaseId { get; set; } = 0;

        /// <summary>
        /// Connection timeout in milliseconds (default: 60000)
        /// </summary>
        public int ConnectTimeout { get; set; } = 60000;

        /// <summary>
        /// Sync timeout in milliseconds (default: 60000)
        /// </summary>
        public int SyncTimeout { get; set; } = 60000;

        /// <summary>
        /// Number of connection retries (default: 3)
        /// </summary>
        public int ConnectRetry { get; set; } = 3;

        /// <summary>
        /// Number of reconnection retry policy (default: 3)
        /// </summary>
        public int ReconnectRetryPolicy { get; set; } = 3;
    }
}
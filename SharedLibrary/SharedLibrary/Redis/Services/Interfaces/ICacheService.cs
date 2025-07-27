namespace SharedLibrary.Cache.Services.Interfaces
{
    /// <summary>
    /// Generic cache service interface for Redis operations
    /// </summary>
    public interface ICacheService
    {
        /// <summary>
        /// Gets a value from cache by key
        /// </summary>
        /// <typeparam name="T">Type of the cached value</typeparam>
        /// <param name="key">Cache key</param>
        /// <returns>Cached value or default if not found</returns>
        Task<T?> GetAsync<T>(string key);

        /// <summary>
        /// Sets a value in cache with optional expiration
        /// </summary>
        /// <typeparam name="T">Type of the value to cache</typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Value to cache</param>
        /// <param name="expiration">Optional expiration time</param>
        /// <returns>True if operation was successful</returns>
        Task<bool> SetAsync<T>(string key, T value, TimeSpan? expiration = null);

        /// <summary>
        /// Removes a value from cache by key
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <returns>True if key was found and removed</returns>
        Task<bool> RemoveAsync(string key);

        /// <summary>
        /// Checks if a key exists in cache
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <returns>True if key exists</returns>
        Task<bool> ExistsAsync(string key);

        /// <summary>
        /// Sets expiration time for an existing key
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <param name="expiration">Expiration time</param>
        /// <returns>True if operation was successful</returns>
        Task<bool> SetExpirationAsync(string key, TimeSpan expiration);

        /// <summary>
        /// Gets the time to live for a key
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <returns>TimeSpan representing TTL or null if key doesn't exist</returns>
        Task<TimeSpan?> GetTimeToLiveAsync(string key);
    }
} 
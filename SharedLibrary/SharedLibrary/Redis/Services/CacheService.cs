using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;
using SharedLibrary.Redis.Services.Interfaces;

namespace SharedLibrary.Redis.Services
{
    /// <summary>
    /// Cache service based on IDistributedCache.
    /// </summary>
    public class CacheService : ICacheService
    {
        private readonly IDistributedCache cache;
        private readonly JsonSerializerOptions jsonOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheService"/> class.
        /// </summary>
        /// <param name="cache">The distributed cache instance.</param>
        public CacheService(IDistributedCache cache)
        {
            this.cache = cache ?? throw new ArgumentNullException(nameof(cache));
            this.jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false,
            };
        }

        /// <inheritdoc/>
        public async Task<T?> GetAsync<T>(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));
                }

                var value = await this.cache.GetStringAsync(key);

                if (value == null)
                {
                    return default;
                }

                return JsonSerializer.Deserialize<T>(value, this.jsonOptions);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to get value for key '{key}'", ex);
            }
        }

        /// <inheritdoc/>
        public async Task SetAsync<T>(string key, T value, TimeSpan? expiration = null)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));
                }

                var serializedValue = JsonSerializer.Serialize(value, this.jsonOptions);
                var options = new DistributedCacheEntryOptions();

                if (expiration.HasValue)
                {
                    options.AbsoluteExpirationRelativeToNow = expiration.Value;
                }

                await this.cache.SetStringAsync(key, serializedValue, options);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set value for key '{key}'", ex);
            }
        }

        /// <inheritdoc/>
        public async Task RemoveAsync(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));
                }

                await this.cache.RemoveAsync(key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to remove key '{key}'", ex);
            }
        }

        /// <inheritdoc/>
        public async Task<bool> ExistsAsync(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));
                }

                var value = await this.cache.GetAsync(key);
                return value != null;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to check existence for key '{key}'", ex);
            }
        }

        /// <inheritdoc/>
        public async Task SetExpirationAsync(string key, TimeSpan expiration)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));
                }

                var value = await this.cache.GetAsync(key);

                if (value == null)
                {
                    throw new Exception("Key doesn't exist in the cache.");
                }

                await this.cache.SetAsync(key, value, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = expiration,
                });
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set expiration for key '{key}'", ex);
            }
        }
    }
}
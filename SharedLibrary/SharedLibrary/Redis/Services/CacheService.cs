using Microsoft.Extensions.Caching.Distributed;
using SharedLibrary.Cache.Services.Interfaces;
using System.Text.Json;

namespace SharedLibrary.Cache.Services
{
    /// <summary>
    /// Cache service based on IDistributedCache.
    /// </summary>
    public class CacheService : ICacheService
    {
        private readonly IDistributedCache _cache;
        private readonly JsonSerializerOptions _jsonOptions;

        public CacheService(IDistributedCache cache)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            };
        }

        public async Task<T?> GetAsync<T>(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                var value = await _cache.GetStringAsync(key);

                if (value == null)
                    return default;

                return JsonSerializer.Deserialize<T>(value, _jsonOptions);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to get value for key '{key}'", ex);
            }
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiration = null)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                var serializedValue = JsonSerializer.Serialize(value, _jsonOptions);
                var options = new DistributedCacheEntryOptions();
                
                if (expiration.HasValue)
                {
                    options.AbsoluteExpirationRelativeToNow = expiration.Value;
                }

                await _cache.SetStringAsync(key, serializedValue, options);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set value for key '{key}'", ex);
            }
        }

        public async Task RemoveAsync(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                await _cache.RemoveAsync(key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to remove key '{key}'", ex);
            }
        }

        public async Task<bool> ExistsAsync(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                var value = await _cache.GetAsync(key);
                return value != null;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to check existence for key '{key}'", ex);
            }
        }

        public async Task SetExpirationAsync(string key, TimeSpan expiration)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                var value = await _cache.GetAsync(key);

                if (value == null)
                    throw new Exception("Key doesn't exist in the cache.");

                await _cache.SetAsync(key, value, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = expiration
                });
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set expiration for key '{key}'", ex);
            }
        }
    }
}
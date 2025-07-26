using SharedLibrary.Cache.Services.Interfaces;
using StackExchange.Redis;
using System.Text.Json;

namespace SharedLibrary.Cache.Services
{
    /// <summary>
    /// Redis implementation of the cache service.
    /// </summary>
    public class RedisCacheService : ICacheService
    {
        private readonly IConnectionMultiplexer _connection;
        private readonly IDatabase _database;
        private readonly JsonSerializerOptions _jsonOptions;

        public RedisCacheService(IConnectionMultiplexer connection, int databaseId = 0)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
            _database = _connection.GetDatabase(databaseId);
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

                var value = await _database.StringGetAsync(key);
                
                if (!value.HasValue)
                    return default;

                return JsonSerializer.Deserialize<T>(value!, _jsonOptions);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to get value for key '{key}'", ex);
            }
        }

        public async Task<bool> SetAsync<T>(string key, T value, TimeSpan? expiration = null)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                var serializedValue = JsonSerializer.Serialize(value, _jsonOptions);
                
                return await _database.StringSetAsync(key, serializedValue, expiration);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set value for key '{key}'", ex);
            }
        }

        public async Task<bool> RemoveAsync(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                return await _database.KeyDeleteAsync(key);
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

                return await _database.KeyExistsAsync(key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to check existence for key '{key}'", ex);
            }
        }

        public async Task<bool> SetExpirationAsync(string key, TimeSpan expiration)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                return await _database.KeyExpireAsync(key, expiration);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set expiration for key '{key}'", ex);
            }
        }

        public async Task<TimeSpan?> GetTimeToLiveAsync(string key)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("Key cannot be null or empty", nameof(key));

                var ttl = await _database.KeyTimeToLiveAsync(key);
                return ttl;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to get TTL for key '{key}'", ex);
            }
        }
    }
} 
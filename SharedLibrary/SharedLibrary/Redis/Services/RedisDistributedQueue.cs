using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Redis.Services
{
    /// <summary>
    /// Redis implementation of IDistributedQueue
    /// </summary>
    public class RedisDistributedQueue : IDistributedQueue
    {
        private readonly IDatabase _database;

        public RedisDistributedQueue(IConnectionMultiplexer connectionMultiplexer, int databaseId = 0)
        {
            _database = connectionMultiplexer.GetDatabase(databaseId);
        }

        public Task<string?> ListGetByIndexAsync(string key, long index)
        {
            return _database.ListGetByIndexAsync(key, index).ContinueWith(t => 
                t.Result.HasValue ? t.Result.ToString() : null);
        }

        public Task<long> ListLengthAsync(string key)
            => _database.ListLengthAsync(key);

        public Task<string?> ListLeftPopAsync(string key)
        {
            return _database.ListLeftPopAsync(key).ContinueWith(t => 
                t.Result.HasValue ? t.Result.ToString() : null);
        }

        public Task<long> ListRightPushAsync(string key, string value)
            => _database.ListRightPushAsync(key, value);

        public Task<bool> KeyDeleteAsync(string key)
            => _database.KeyDeleteAsync(key);

    }
}
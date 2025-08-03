using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Redis.Services
{
    /// <summary>
    /// Redis implementation of IDistributedQueue.
    /// </summary>
    public class RedisDistributedQueue : IDistributedQueue
    {
        private readonly IDatabase database;

        /// <summary>
        /// Initializes a new instance of the <see cref="RedisDistributedQueue"/> class,  which provides a distributed
        /// queue implementation using Redis.
        /// </summary>
        /// <param name="connectionMultiplexer">The connection multiplexer used to connect to the Redis server.</param>
        /// <param name="databaseId">The ID of the Redis database to use. Defaults to 0 if not specified.</param>
        public RedisDistributedQueue(IConnectionMultiplexer connectionMultiplexer, int databaseId = 0)
        {
            this.database = connectionMultiplexer.GetDatabase(databaseId);
        }

        /// <inheritdoc/>
        public Task<string?> ListGetByIndexAsync(string key, long index)
        {
            return this.database.ListGetByIndexAsync(key, index).ContinueWith(t =>
                t.Result.HasValue ? t.Result.ToString() : null);
        }

        /// <inheritdoc/>
        public Task<long> ListLengthAsync(string key)
            => this.database.ListLengthAsync(key);

        /// <inheritdoc/>
        public Task<string?> ListLeftPopAsync(string key)
        {
            return this.database.ListLeftPopAsync(key).ContinueWith(t =>
                t.Result.HasValue ? t.Result.ToString() : null);
        }

        /// <inheritdoc/>
        public Task<long> ListRightPushAsync(string key, string value)
            => this.database.ListRightPushAsync(key, value);

        /// <inheritdoc/>
        public Task<bool> KeyDeleteAsync(string key)
            => this.database.KeyDeleteAsync(key);
    }
}
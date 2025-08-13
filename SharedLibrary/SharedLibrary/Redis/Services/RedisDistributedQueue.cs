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
        public async Task<string?> ListGetByIndexAsync(string key, long index)
        {
            var result = await this.database.ListGetByIndexAsync(key, index);
            return result.HasValue ? result.ToString() : null;
        }

        /// <inheritdoc/>
        public Task<long> ListLengthAsync(string key)
            => this.database.ListLengthAsync(key);

        /// <inheritdoc/>
        public async Task<RedisValue?> ListLeftPopAsync(string key)
        {
            var result = await this.database.ListLeftPopAsync(key);
            return result.HasValue ? result : (RedisValue?)null;
        }

        /// <inheritdoc/>
        public Task<long> ListRightPushAsync(string key, string value)
            => this.database.ListRightPushAsync(key, value);

        /// <inheritdoc/>
        public Task<bool> KeyDeleteAsync(string key)
            => this.database.KeyDeleteAsync(key);

        /// <inheritdoc/>
        public async Task<IEnumerable<RedisValue>?> ListLeftRangePopAsync(string key, long fetchCount = 1)
        {
            var values = await this.database.ListLeftPopAsync(key, fetchCount);
            if (values == null || values.Length == 0)
            {
                return null;
            }

            return [.. values];
        }
    }
}
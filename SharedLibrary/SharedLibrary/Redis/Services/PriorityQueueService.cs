using System.Text.Json;
using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Redis.Services;

/// <inheritdoc/>
public class PriorityQueueService : IPriorityQueueService
{
    private readonly IDatabase database;

    /// <summary>
    /// Initializes a new instance of the <see cref="PriorityQueueService"/> class.
    /// </summary>
    /// <param name="connectionMultiplexer">The Redis connection multiplexer.</param>
    /// <param name="databaseId">The Redis database ID (default: 0).</param>
    public PriorityQueueService(IConnectionMultiplexer connectionMultiplexer, int databaseId = 0)
    {
        this.database = connectionMultiplexer.GetDatabase(databaseId);
    }

    /// <inheritdoc/>
    public async Task EnqueueAsync<T>(string queueName, T item, double priority)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        if (item is null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        var serialized = JsonSerializer.Serialize(item);
        await this.database.SortedSetAddAsync(queueName, serialized, priority);
    }

    /// <inheritdoc/>
    public async Task<T?> DequeueAsync<T>(string queueName)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        var entry = await this.database.SortedSetRangeByRankAsync(queueName, 0, 0, Order.Ascending);
        if (entry.Length == 0)
        {
            return default;
        }

        var value = entry[0];
        await this.database.SortedSetRemoveAsync(queueName, value);
        return JsonSerializer.Deserialize<T>(value!);
    }

    /// <inheritdoc/>
    public async Task<List<T>> DequeueByScoreAsync<T>(string queueName, double minScore, double maxScore, int? maxFetchCount = null)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        var entries = await this.database.SortedSetRangeByScoreAsync(
            queueName,
            minScore,
            maxScore,
            Exclude.None,
            Order.Ascending,
            skip: 0,
            take: maxFetchCount ?? -1);

        if (entries.Length == 0)
        {
            return [];
        }

        var items = new List<T>();
        foreach (var entry in entries)
        {
            var item = JsonSerializer.Deserialize<T>(entry!);
            if (item is not null)
            {
                items.Add(item);
            }

            await this.database.SortedSetRemoveAsync(queueName, entry);
        }

        return items;
    }

    /// <inheritdoc/>
    public async Task<T?> PeekAsync<T>(string queueName)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        var entry = await this.database.SortedSetRangeByRankAsync(queueName, 0, 0, Order.Ascending);
        if (entry.Length == 0)
        {
            return default;
        }

        return JsonSerializer.Deserialize<T>(entry[0] !);
    }

    /// <inheritdoc/>
    public async Task<long> GetLengthAsync(string queueName)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        return await this.database.SortedSetLengthAsync(queueName);
    }

    /// <inheritdoc/>
    public async Task ClearAsync(string queueName)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        await this.database.KeyDeleteAsync(queueName);
    }
}

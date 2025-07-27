using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;
using System.Text.Json;

namespace SharedLibrary.Redis.Services;

/// <summary>
/// Redis implementation of the queue service.
/// </summary>
public class RedisQueueService : IQueueService
{
    private readonly IDatabase _database;

    public RedisQueueService(IConnectionMultiplexer connectionMultiplexer, int databaseId = 0)
    {
        _database = connectionMultiplexer.GetDatabase(databaseId);
    }

    public async Task EnqueueAsync<T>(string queueName, T item)
    {
        if (queueName is null) throw new ArgumentNullException(nameof(queueName));
        if (item is null) throw new ArgumentNullException(nameof(item));
        var serialized = JsonSerializer.Serialize(item);
        await _database.ListRightPushAsync(queueName, serialized);
    }

    public async Task<T?> DequeueAsync<T>(string queueName)
    {
        if (queueName is null) throw new ArgumentNullException(nameof(queueName));
        var value = await _database.ListLeftPopAsync(queueName);
        return value.HasValue ? JsonSerializer.Deserialize<T>(value.ToString()) : default;
    }

    public async Task<T?> PeekAsync<T>(string queueName)
    {
        if (queueName is null) throw new ArgumentNullException(nameof(queueName));
        var value = await _database.ListGetByIndexAsync(queueName, 0);
        return value.HasValue ? JsonSerializer.Deserialize<T>(value.ToString()) : default;
    }

    public async Task<long> GetLengthAsync(string queueName)
    {
        if (queueName is null) throw new ArgumentNullException(nameof(queueName));
        return await _database.ListLengthAsync(queueName);
    }

    public async Task ClearAsync(string queueName)
    {
        if (queueName is null) throw new ArgumentNullException(nameof(queueName));
        await _database.KeyDeleteAsync(queueName);
    }
}

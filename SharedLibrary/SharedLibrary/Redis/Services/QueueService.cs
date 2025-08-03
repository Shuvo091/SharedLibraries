using SharedLibrary.Redis.Services.Interfaces;
using System.Text.Json;

namespace SharedLibrary.Redis.Services;

/// <summary>
/// Redis implementation of the queue service.
/// </summary>
public class QueueService : IQueueService
{
    private readonly IDistributedQueue _queue;

    public QueueService(IDistributedQueue queue)
    {
        _queue = queue;
    }

    public async Task EnqueueAsync<T>(string queueName, T item)
    {
        try
        {
            if (queueName is null) throw new ArgumentNullException(nameof(queueName));
            if (item is null) throw new ArgumentNullException(nameof(item));

            var serialized = JsonSerializer.Serialize(item);
            await _queue.ListRightPushAsync(queueName, serialized);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to enqueue item in queue '{queueName}'", ex);
        }
    }

    public async Task<T?> DequeueAsync<T>(string queueName)
    {
        try
        {
            if (queueName is null) throw new ArgumentNullException(nameof(queueName));

            var value = await _queue.ListLeftPopAsync(queueName);
            return value != null ? JsonSerializer.Deserialize<T>(value) : default;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to dequeue item from queue '{queueName}'", ex);
        }
    }

    public async Task<T?> PeekAsync<T>(string queueName)
    {
        if (queueName is null) throw new ArgumentNullException(nameof(queueName));
        var value = await _queue.ListGetByIndexAsync(queueName, 0);
        return value != null ? JsonSerializer.Deserialize<T>(value) : default;
    }

    public async Task<long> GetLengthAsync(string queueName)
    {
        try
        {
            if (queueName is null) throw new ArgumentNullException(nameof(queueName));
            return await _queue.ListLengthAsync(queueName);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to get length of queue '{queueName}'", ex);
        }
    }

    public async Task ClearAsync(string queueName)
    {
        try
        {
            if (queueName is null) throw new ArgumentNullException(nameof(queueName));
            await _queue.KeyDeleteAsync(queueName);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to clear queue '{queueName}'", ex);
        }
    }
}

using System.Text.Json;
using SharedLibrary.Redis.Services.Interfaces;

namespace SharedLibrary.Redis.Services;

/// <summary>
/// Redis implementation of the queue service.
/// </summary>
public class QueueService : IQueueService
{
    private readonly IDistributedQueue queue;

    /// <summary>
    /// Initializes a new instance of the <see cref="QueueService"/> class with the specified distributed queue.
    /// </summary>
    /// <param name="queue">The distributed queue instance used by the service to enqueue and dequeue messages. Cannot be null.</param>
    public QueueService(IDistributedQueue queue)
    {
        this.queue = queue;
    }

    /// <inheritdoc/>
    public async Task EnqueueAsync<T>(string queueName, T item)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(queueName);

            if (item is null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            var serialized = JsonSerializer.Serialize(item);
            await this.queue.ListRightPushAsync(queueName, serialized);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to enqueue item in queue '{queueName}'", ex);
        }
    }

    /// <inheritdoc/>
    public async Task<T?> DequeueAsync<T>(string queueName)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(queueName);
            var value = await this.queue.ListLeftPopAsync(queueName);
            return value.HasValue ? JsonSerializer.Deserialize<T>(value!) : default;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to dequeue item from queue '{queueName}'", ex);
        }
    }

    /// <inheritdoc/>
    public async Task<List<T>> DequeueRangeAsync<T>(string queueName, long fetchCount = 1)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        var values = await this.queue.ListLeftRangePopAsync(queueName, fetchCount);
        if (values is null)
        {
            return [];
        }

        return [.. values
            .Select(value => JsonSerializer.Deserialize<T>(value.ToString()))];
    }

    /// <inheritdoc/>
    public async Task<T?> PeekAsync<T>(string queueName)
    {
        ArgumentNullException.ThrowIfNull(queueName);
        var value = await this.queue.ListGetByIndexAsync(queueName, 0);
        return value != null ? JsonSerializer.Deserialize<T>(value) : default;
    }

    /// <inheritdoc/>
    public async Task<long> GetLengthAsync(string queueName)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(queueName);
            return await this.queue.ListLengthAsync(queueName);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to get length of queue '{queueName}'", ex);
        }
    }

    /// <inheritdoc/>
    public async Task ClearAsync(string queueName)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(queueName);
            await this.queue.KeyDeleteAsync(queueName);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to clear queue '{queueName}'", ex);
        }
    }
}
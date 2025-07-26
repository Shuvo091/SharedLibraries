namespace SharedLibrary.Redis.Services.Interfaces;

/// <summary>
/// Defines a service for managing queue operations, including adding, retrieving, and clearing items in named queues.
/// </summary>
public interface IQueueService
{
    /// <summary>
    /// Enqueues an item to the specified queue.
    /// </summary>
    /// <param name="queueName">The name of the queue.</param>
    /// <param name="item">The item to enqueue.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task EnqueueAsync<T>(string queueName, T item);

    /// <summary>
    /// Dequeues an item from the specified queue.
    /// </summary>
    /// <param name="queueName">The name of the queue.</param>
    /// <returns>The dequeued item, or null if the queue is empty.</returns>
    Task<T?> DequeueAsync<T>(string queueName);

    /// <summary>
    /// Gets the length of the specified queue.
    /// </summary>
    /// <param name="queueName">The name of the queue.</param>
    /// <returns>The length of the queue.</returns>
    Task<long> GetLengthAsync(string queueName);

    /// <summary>
    /// Peeks at the next item in the specified queue without removing it.
    /// </summary>
    /// <param name="queueName">The name of the queue.</param>
    /// <returns>The next item in the queue, or null if the queue is empty.</returns>
    Task<T?> PeekAsync<T>(string queueName);

    /// <summary>
    /// Clears all items from the specified queue.
    /// </summary>
    /// <param name="queueName">The name of the queue.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task ClearAsync(string queueName);
}

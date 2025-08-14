using StackExchange.Redis;

namespace SharedLibrary.Redis.Services.Interfaces
{
    /// <summary>
    /// Defines a service for managing priority queue operations in Redis.
    /// </summary>
    public interface IPriorityQueueService
    {
        /// <summary>
        /// Enqueues an item with a given priority.
        /// </summary>
        /// <typeparam name="T">The type of the item to enqueue.</typeparam>
        /// <param name="queueName">The name of the priority queue.</param>
        /// <param name="item">The item to enqueue.</param>
        /// <param name="priority">The priority score (lower means higher priority).</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EnqueueAsync<T>(string queueName, T item, double priority);

        /// <summary>
        /// Dequeues the highest priority item.
        /// </summary>
        /// <typeparam name="T">The type of the item to dequeue.</typeparam>
        /// <param name="queueName">The name of the priority queue.</param>
        /// <returns>The dequeued item, or null if the queue is empty.</returns>
        Task<T?> DequeueAsync<T>(string queueName);

        /// <summary>
        /// Dequeues items within a specified score range.
        /// </summary>
        /// <typeparam name="T">The type of the item to dequeue.</typeparam>
        /// <param name="queueName">The name of the priority queue.</param>
        /// <param name="minScore">Minimum score range.</param>
        /// <param name="maxScore">Maximum score range.</param>
        /// <param name="maxFetchCount">Max fetched items.</param>
        /// <returns>The dequeued items, or null if the queue is empty.</returns>
        Task<List<T>> DequeueByScoreAsync<T>(string queueName, double minScore, double maxScore, int? maxFetchCount = null);

        /// <summary>
        /// Peeks at the highest priority item without removing it.
        /// </summary>
        /// <typeparam name="T">The type of the item to peek.</typeparam>
        /// <param name="queueName">The name of the priority queue.</param>
        /// <returns>The item, or null if the queue is empty.</returns>
        Task<T?> PeekAsync<T>(string queueName);

        /// <summary>
        /// Gets the length of the priority queue.
        /// </summary>
        /// <param name="queueName">The name of the priority queue.</param>
        /// <returns>The length of the queue.</returns>
        Task<long> GetLengthAsync(string queueName);

        /// <summary>
        /// Clears all items from the priority queue.
        /// </summary>
        /// <param name="queueName">The name of the priority queue.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task ClearAsync(string queueName);
    }
}

using System.Text.Json;

namespace SharedLibrary.Redis.Services.Interfaces
{
    /// <summary>
    /// Represents a distributed queue abstraction.
    /// Queue is popping from the left and pushing to the right.
    /// </summary>
    public interface IDistributedQueue
    {
        /// <summary>
        /// Pushes an item to the right end of the queue.
        /// </summary>
        /// <param name="key">The key of the queue.</param>
        /// <param name="value">The value to push onto the queue.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains the new length of the queue.</returns>
        Task<long> ListRightPushAsync(string key, string value);

        /// <summary>
        /// Removes and returns the leftmost element of the queue.
        /// </summary>
        /// <param name="key">The key of the queue.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains the value that was removed, or <c>null</c> if the queue is empty.</returns>
        Task<string?> ListLeftPopAsync(string key);

        /// <summary>
        /// Gets an element at the specified index without removing it.
        /// </summary>
        /// <param name="key">The key of the queue.</param>
        /// <param name="index">The index of the element to retrieve.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains the value at the specified index, or <c>null</c> if the index is out of range.</returns>
        Task<string?> ListGetByIndexAsync(string key, long index);

        /// <summary>
        /// Gets the length of the queue.
        /// </summary>
        /// <param name="key">The key of the queue.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains the length of the queue.</returns>
        Task<long> ListLengthAsync(string key);

        /// <summary>
        /// Removes the specified key and its associated queue.
        /// </summary>
        /// <param name="key">The key of the queue to delete.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains <c>true</c> if the key was removed; otherwise, <c>false</c>.</returns>
        Task<bool> KeyDeleteAsync(string key);
    }
}
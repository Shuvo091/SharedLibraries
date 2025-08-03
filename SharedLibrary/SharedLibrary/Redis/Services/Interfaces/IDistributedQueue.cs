using System.Text.Json;

namespace SharedLibrary.Redis.Services.Interfaces
{
    /// <summary>
    /// Represents a distributed queue abstraction.
    /// Queue is poping from the left and pushing to the right.
    /// </summary>
    public interface IDistributedQueue
    {
        /// <summary>
        /// Pushes an item to the right end of the queue
        /// </summary>
        Task<long> ListRightPushAsync(string key, string value);

        /// <summary>
        /// Removes and returns the leftmost element of the queue
        /// </summary>
        Task<string?> ListLeftPopAsync(string key);

        /// <summary>
        /// Gets an element at the specified index without removing it
        /// </summary>
        Task<string?> ListGetByIndexAsync(string key, long index);

        /// <summary>
        /// Gets the length of the queue
        /// </summary>
        Task<long> ListLengthAsync(string key);

        /// <summary>
        /// Removes the specified key and its associated queue
        /// </summary>
        Task<bool> KeyDeleteAsync(string key);
    }
}
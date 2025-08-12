namespace SharedLibrary.Redis.Services.Interfaces;

/// <summary>
/// Defines a service for managing atomic counters in Redis.
/// </summary>
public interface ICounterService
{
    /// <summary>
    /// Increments the counter value for the specified key by the given amount (default 1).
    /// </summary>
    /// <param name="key">The key of the counter.</param>
    /// <param name="amount">The amount to increment by (default 1).</param>
    /// <returns>The new value of the counter.</returns>
    Task<long> IncrementAsync(string key, long amount = 1);

    /// <summary>
    /// Decrements the counter value for the specified key by the given amount (default 1).
    /// </summary>
    /// <param name="key">The key of the counter.</param>
    /// <param name="amount">The amount to decrement by (default 1).</param>
    /// <returns>The new value of the counter.</returns>
    Task<long> DecrementAsync(string key, long amount = 1);
}

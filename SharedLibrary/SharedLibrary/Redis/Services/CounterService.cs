using SharedLibrary.Redis.Services.Interfaces;
using StackExchange.Redis;

namespace SharedLibrary.Redis.Services;

/// <summary>
/// Redis implementation of the counter service.
/// </summary>
public class CounterService : ICounterService
{
    private readonly IDatabase database;

    /// <summary>
    /// Initializes a new instance of the <see cref="CounterService"/> class.
    /// </summary>
    /// <param name="connectionMultiplexer">The Redis connection multiplexer.</param>
    /// <param name="databaseId">The Redis database ID (default 0).</param>
    public CounterService(IConnectionMultiplexer connectionMultiplexer, int databaseId = 0)
    {
        this.database = connectionMultiplexer.GetDatabase(databaseId);
    }

    /// <inheritdoc/>
    public async Task<long> IncrementAsync(string key, long amount = 1)
    {
        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Key cannot be null or empty", nameof(key));
        }

        try
        {
            return await this.database.StringIncrementAsync(key, amount);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to increment counter for key '{key}'", ex);
        }
    }

    /// <inheritdoc/>
    public async Task<long> DecrementAsync(string key, long amount = 1)
    {
        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Key cannot be null or empty", nameof(key));
        }

        try
        {
            return await this.database.StringDecrementAsync(key, amount);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to decrement counter for key '{key}'", ex);
        }
    }

    /// <inheritdoc/>
    public async Task<long?> GetAsync(string key)
    {
        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Key cannot be null or empty", nameof(key));
        }

        try
        {
            var value = await this.database.StringGetAsync(key);
            if (value.IsNull)
            {
                return null;
            }

            if (long.TryParse(value, out var result))
            {
                return result;
            }

            throw new InvalidOperationException($"Value for key '{key}' is not a valid long.");
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to get counter for key '{key}'", ex);
        }
    }

    /// <inheritdoc/>
    public async Task SetAsync(string key, long value)
    {
        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Key cannot be null or empty", nameof(key));
        }

        try
        {
            await this.database.StringSetAsync(key, value);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to set counter for key '{key}'", ex);
        }
    }
}

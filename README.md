# Shared Library

<details>
<summary>Redis Services</summary>

Provides various Redis functionalities for microservices.

<details>
<summary><strong>Caching Functionality</strong></summary>

The `ICacheService` interface provides caching operations:

```csharp
public interface ICacheService
{
    Task<T?> GetAsync<T>(string key);
    Task<bool> SetAsync<T>(string key, T value, TimeSpan? expiration = null);
    Task<bool> RemoveAsync(string key);
    Task<bool> ExistsAsync(string key);
    Task<bool> SetExpirationAsync(string key, TimeSpan expiration);
    Task<TimeSpan?> GetTimeToLiveAsync(string key);
}
```
</details>

<details>
<summary><strong>Queue Functionality</strong></summary>

The `IQueueService` interface provides queue operations:

```csharp
public interface IQueueService
{
    Task EnqueueAsync<T>(string queueName, T item);
    Task<T?> DequeueAsync<T>(string queueName);
    Task<long> GetLengthAsync(string queueName);
    Task<T?> PeekAsync<T>(string queueName);
    Task ClearAsync(string queueName);
}
```
</details>

<details>
<summary><strong>Dependency Injection Setup</strong></summary>

### 1. Configuration

Add Redis configuration to your `appsettings.json`:

```json
{
  "Redis": {
    "ConnectionString": "localhost:6379",
    "DatabaseId": 0,
    "ConnectTimeout": 60000,
    "SyncTimeout": 60000,
    "ConnectRetry": 3,
    "ReconnectRetryPolicy": 3
  }
}
```

### 2. Service Registration

In your `Program.cs` or `Startup.cs`:

```csharp
using SharedLibrary.Cache.ServiceCollectionExtensions;

// Add Redis connection
builder.Services.AddRedis(configuration);

// Add Redis cache service
builder.Services.AddRedisCache(configuration);

// Add Redis queue service
builder.Services.AddRedisQueue(configuration);
```

</details>
</details>

<details>
<summary><strong>Dependencies</strong></summary>

- StackExchange.Redis
- Microsoft.Extensions.DependencyInjection
- Microsoft.Extensions.Configuration
- Microsoft.Extensions.Logging
</details>
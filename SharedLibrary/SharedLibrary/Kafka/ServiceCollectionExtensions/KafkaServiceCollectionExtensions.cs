using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedLibrary.Kafka.Models;
using SharedLibrary.Kafka.Services;
using SharedLibrary.Kafka.Services.Interfaces;

namespace SharedLibrary.Kafka.ServiceCollectionExtensions;

/// <summary>
/// Extension methods for IServiceCollection to configure Kafka caching.
/// </summary>
public static class KafkaServiceCollectionExtensions
{
    /// <summary>
    /// Adds Kafka necessaries to the service collection.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to which the Kafka service will be added.</param>
    /// <param name="configuration">The application configuration containing the Kafka settings.</param>
    /// <param name="sectionName">The name of the configuration section that contains the Kafka settings.  Defaults to "Kafka".</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddKafka(
        this IServiceCollection services,
        IConfiguration configuration,
        string sectionName = nameof(KafkaOptions))
    {
        // Bind options so it can be injected via IOptions<KafkaOptions>
        services.Configure<KafkaOptions>(configuration.GetSection(sectionName));

        // Register KafkaEventBusService as singleton
        services.AddSingleton<IEventBus, KafkaEventBusService>();
        return services;
    }
}
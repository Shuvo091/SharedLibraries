using System.Text;
using CloudNative.CloudEvents;
using CloudNative.CloudEvents.SystemTextJson;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SharedLibrary.Kafka.Models;
using SharedLibrary.Kafka.Services.Interfaces;

namespace SharedLibrary.Kafka.Services;

/// <summary>
/// Event bus implementation for kafka.
/// </summary>
public class KafkaEventBusService : IEventBus, IDisposable
{
    private readonly ILogger<KafkaEventBusService> logger;
    private readonly IProducer<Null, byte[]> producer;

    /// <summary>
    /// Initializes a new instance of the <see cref="KafkaEventBusService"/> class.
    /// Initializes the kafka event bus.
    /// </summary>
    /// <param name="configuration"> config for kafka.</param>
    /// <param name="logger">logger.</param>
    public KafkaEventBusService(IConfiguration configuration, ILogger<KafkaEventBusService> logger)
    {
        this.logger = logger;
        var kafkaOptions = configuration.GetSection(nameof(KafkaOptions)).Get<KafkaOptions>()
            ?? throw new InvalidOperationException("Kafka options not found.");

        if (string.IsNullOrWhiteSpace(kafkaOptions.BootstrapServers))
        {
            throw new ArgumentException("Kafka BootstrapServers is required in configuration.");
        }

        var producerConfig = new ProducerConfig
        {
            BootstrapServers = kafkaOptions.BootstrapServers,
            EnableIdempotence = true,
            Acks = Acks.All,
            MessageTimeoutMs = 5000,
        };

        this.producer = new ProducerBuilder<Null, byte[]>(producerConfig)
            .SetErrorHandler((_, e) => this.logger.LogError("Kafka producer error: {Reason}", e.Reason))
            .Build();
    }

    /// <inheritdoc/>
    public async Task PublishAsync(CloudEvent cloudEvent, string topic, CancellationToken cancellationToken = default)
    {
        var formatter = new JsonEventFormatter();
        var jsonBytes = formatter.EncodeStructuredModeMessage(cloudEvent, out var contentType);

        var headers = new Headers
            {
                { "ce_id", Encoding.UTF8.GetBytes(cloudEvent.Id!) },
                { "ce_type", Encoding.UTF8.GetBytes(cloudEvent.Type!) },
                { "ce_source", Encoding.UTF8.GetBytes(cloudEvent.Source?.ToString() ?? string.Empty) },
                { "ce_specversion", Encoding.UTF8.GetBytes(cloudEvent.SpecVersion.VersionId) },
                { "Content-Type", Encoding.UTF8.GetBytes(contentType.MediaType) },
            };

        var message = new Message<Null, byte[]>
        {
            Value = jsonBytes.ToArray(),
            Headers = headers,
        };

        try
        {
            var maxRetries = 5;
            var delayMs = 2000;

            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    var delivery = await this.producer.ProduceAsync(topic, message, cancellationToken);
                    this.logger.LogInformation("CloudEvent published to Kafka: {Type} {Id} [Partition: {Partition}, Offset: {Offset}]", cloudEvent.Type, cloudEvent.Id, delivery.Partition, delivery.Offset);
                    break; // success
                }
                catch (KafkaException)
                {
                    if (i == maxRetries - 1)
                    {
                        throw;
                    }

                    await Task.Delay(delayMs);
                }
            }
        }
        catch (ProduceException<Null, byte[]> ex)
        {
            this.logger.LogError(ex, "Failed to publish CloudEvent {Id}: {Reason}", cloudEvent.Id, ex.Error.Reason);
            throw;
        }
    }

    /// <summary>
    /// Disposes the object.
    /// </summary>
    public void Dispose()
    {
        this.producer.Flush(TimeSpan.FromSeconds(10));
        this.producer.Dispose();
        GC.SuppressFinalize(this);
    }
}
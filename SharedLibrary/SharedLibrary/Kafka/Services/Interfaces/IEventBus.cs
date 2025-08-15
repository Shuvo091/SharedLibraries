using CloudNative.CloudEvents;

namespace SharedLibrary.Kafka.Services.Interfaces;

/// <summary>
/// Defines an event bus for publishing events.
/// </summary>
public interface IEventBus
{
    /// <summary>
    /// Publishes an event.
    /// </summary>
    /// <param name="cloudEvent"> the cloud event. </param>
    /// <param name="topic"> the event topic event. </param>
    /// <param name="cancellationToken"> cancellation token.</param>
    /// <returns>returns a task.</returns>
    Task PublishAsync(CloudEvent cloudEvent, string topic, CancellationToken cancellationToken = default);
}
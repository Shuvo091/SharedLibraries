namespace SharedLibrary.Kafka.Models;

/// <summary>
/// Kafka Options from config.
/// </summary>
public class KafkaOptions
{
    /// <summary>
    /// Gets or sets BootstrapServers.
    /// </summary>
    public string BootstrapServers { get; set; } = default!;

    /// <summary>
    /// Gets or sets GroupId minutes.
    /// </summary>
    public string GroupId { get; set; } = default!;
}
namespace SharedLibrary.Contracts.AudioChunker;

/// <summary>
/// Chunk meta data for individual chunks.
/// </summary>
public class ChunkInfo
{
    /// <summary>
    /// Gets or sets Chunk URI.
    /// </summary>
    public string ChunkUri { get; set; } = default!;

    /// <summary>
    /// Gets or sets the chunk Id.
    /// </summary>
    public string? ChunkId { get; set; }

    /// <summary>
    /// Gets or sets start MS.
    /// </summary>
    public int StartMs { get; set; }

    /// <summary>
    /// Gets or sets end MS.
    /// </summary>
    public int EndMs { get; set; }

    /// <summary>
    /// Gets or sets total duration of the individual chunk.
    /// </summary>
    public int DurationMs { get; set; }

    /// <summary>
    /// Gets or sets checksum value.
    /// </summary>
    public string Checksum { get; set; } = default!;
}
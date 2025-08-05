namespace SharedLibrary.Contracts.AudioChunker;

/// <summary>
/// Audio job chunk manifest.
/// </summary>
public class ChunkManifest
{
    /// <summary>
    /// Gets or sets Job Id for audio chunk.
    /// </summary>
    public Guid JobId { get; set; }

    /// <summary>
    /// Gets or sets status of the job (Pending, completed, rejected).
    /// </summary>
    public string Status { get; set; } = default!;

    /// <summary>
    /// Gets or sets info for all teh chunks of that audio.
    /// </summary>
    public List<ChunkInfo> Chunks { get; set; } = new List<ChunkInfo>();
}
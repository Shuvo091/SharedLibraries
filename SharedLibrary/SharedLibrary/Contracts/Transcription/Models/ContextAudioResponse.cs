namespace SharedLibrary.Contracts.Transcription.Models;

/// <summary>
/// Response model for successful context audio retrieval.
/// </summary>
public class ContextAudioResponse
{
    /// <summary>
    /// Gets or sets the signed URI of the concatenated context audio file.
    /// </summary>
    public string ContextAudioUri { get; set; } = default!;

    /// <summary>
    /// Gets or sets metadata describing the context segments and concatenation info.
    /// </summary>
    public ContextMetadata ContextMetadata { get; set; } = default!;

    /// <summary>
    /// Gets or sets Guidance and instruction for the transcription task.
    /// </summary>
    public TranscriptionGuidance TranscriptionGuidance { get; set; } = default!;

    /// <summary>
    /// Gets or sets Expiration timestamp for the signed audio URI.
    /// </summary>
    public DateTime ExpiresAt { get; set; }
}

/// <summary>
/// Metadata about the context segments and audio processing.
/// </summary>
public class ContextMetadata
{
    /// <summary>
    /// Gets or sets The total duration of the concatenated audio.
    /// </summary>
    public string TotalDuration { get; set; } = default!;

    /// <summary>
    /// Gets or sets The list of segments included in the concatenated audio.
    /// </summary>
    public List<ContextSegment> Segments { get; set; } = new ();

    /// <summary>
    /// Gets or sets Information about how the audio was concatenated.
    /// </summary>
    public ConcatenationInfo ConcatenationInfo { get; set; } = default!;
}

/// <summary>
/// Describes a single segment in the context audio.
/// </summary>
public class ContextSegment
{
    /// <summary>
    /// Gets or sets The type of the segment: previous, current, or next.
    /// </summary>
    public string Type { get; set; } = default!;

    /// <summary>
    /// Gets or sets The ID of the chunk.
    /// </summary>
    public string ChunkId { get; set; } = default!;

    /// <summary>
    /// Gets or sets Start time of the segment.
    /// </summary>
    public string StartTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets End time of the segment.
    /// </summary>
    public string EndTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets Signed URI for the original segment audio file.
    /// </summary>
    public string AudioUri { get; set; } = default!;

    /// <summary>
    /// Gets or sets Whether this segment is the target for transcription.
    /// </summary>
    public bool? TranscriptionTarget { get; set; }
}

/// <summary>
/// Metadata about how the audio was processed and exported.
/// </summary>
public class ConcatenationInfo
{
    /// <summary>
    /// Gets or sets a value indicating whether gets or sets Seamless transition flag.
    /// </summary>
    public bool SeamlessTransitions { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether gets or sets NormalizedVolume.
    /// </summary>
    public bool NormalizedVolume { get; set; }

    /// <summary>
    /// Gets or sets format.
    /// </summary>
    public string Format { get; set; } = default!;

    /// <summary>
    /// Gets or sets filesize.
    /// </summary>
    public string FileSize { get; set; } = default!;
}

/// <summary>
/// Instructions and guidance for transcription.
/// </summary>
public class TranscriptionGuidance
{
    /// <summary>
    /// Gets or sets The segment that should be transcribed (target).
    /// </summary>
    public FocusSegment FocusSegment { get; set; } = default!;

    /// <summary>
    /// Gets or sets Instructions about how to use context segments.
    /// </summary>
    public string ContextNotes { get; set; } = default!;

    /// <summary>
    /// Gets or sets Recommended playback strategy.
    /// </summary>
    public string PlaybackRecommendation { get; set; } = default!;
}

/// <summary>
/// Start and end of the segment to transcribe.
/// </summary>
public class FocusSegment
{
    /// <summary>
    /// Gets or sets StartTime.
    /// </summary>
    public string StartTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets EndTime.
    /// </summary>
    public string EndTime { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether gets or sets HighlightInPlayer.
    /// </summary>
    public bool HighlightInPlayer { get; set; }
}
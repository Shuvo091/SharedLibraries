using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.AppEnums;

/// <summary>
/// Specifies the role of a transcriber in a three-way transcription process.
/// </summary>
public enum ThreeWayTranscriberRoleType
{
    /// <summary>
    /// The first original transcriber.
    /// </summary>
    [Display(Name = "original_transcriber_1")]
    OriginalTranscriber1,

    /// <summary>
    /// The second original transcriber.
    /// </summary>
    [Display(Name = "original_transcriber_2")]
    OriginalTranscriber2,

    /// <summary>
    /// The tiebreaker transcriber.
    /// </summary>
    [Display(Name = "tiebreaker_transcriber")]
    TiebreakerTranscriber,
}
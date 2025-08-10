using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharedLibrary.Common.Utilities;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents the role of a participant in a comparison.
/// </summary>
[JsonConverter(typeof(EnumConverter<ParticipantRole>))]
public enum ParticipantRole
{
    /// <summary>
    /// Original transcriber role.
    /// </summary>
    [Display(Name = "original_transcriber")]
    OriginalTranscriber,

    /// <summary>
    /// Tiebreaker transcriber role.
    /// </summary>
    [Display(Name = "tiebreaker_transcriber")]
    TiebreakerTranscriber,
}
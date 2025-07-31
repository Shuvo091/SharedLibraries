using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum ThreeWayTranscriberRoleType
{
    [Display(Name = "original_transcriber_1")]
    OriginalTranscriber1,

    [Display(Name = "original_transcriber_2")]
    OriginalTranscriber2,

    [Display(Name = "tiebreaker_transcriber")]
    TiebreakerTranscriber
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharedLibrary.Common.Utilities;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents timeframe for analytics.
/// </summary>
[JsonConverter(typeof(EnumConverter<TimeFrame>))]
public enum TimeFrame
{
    /// <summary>
    /// Indicates 7 days of analytics.
    /// </summary>
    [Display(Name = "7d")]
    D7,

    /// <summary>
    /// Indicates 30 days of analytics.
    /// </summary>
    [Display(Name = "30d")]
    D30,

    /// <summary>
    /// Indicates 90 days of analytics.
    /// </summary>
    [Display(Name = "90d")]
    D90,

    /// <summary>
    /// Indicates all time analytics.
    /// </summary>
    [Display(Name = "all_time")]
    AllTime,
}

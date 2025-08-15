using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharedLibrary.Common.Utilities;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents dialects for analytics.
/// </summary>
[JsonConverter(typeof(EnumConverter<Dialect>))]
public enum Dialect
{
    /// <summary>
    /// Indicates western cape dialect.
    /// </summary>
    [Display(Name = "western_cape")]
    WesternCape,

    /// <summary>
    /// Indicates northern cape dialect.
    /// </summary>
    [Display(Name="eastern_cape")]
    EasternCape,
}

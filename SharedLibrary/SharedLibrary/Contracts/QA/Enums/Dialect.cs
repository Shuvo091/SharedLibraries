using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.QA.Enums;

/// <summary>
/// Represents dialects for analytics.
/// </summary>
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

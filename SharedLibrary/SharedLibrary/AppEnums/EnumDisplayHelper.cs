using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SharedLibrary.AppEnums;

/// <summary>
/// Provides helper methods for working with enum display names using <see cref="DisplayAttribute"/>.
/// </summary>
public static class EnumDisplayHelper
{
    /// <summary>
    /// Gets the display name of an enum value using the <see cref="DisplayAttribute"/>, or the enum name if not present.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <param name="enumValue">The enum value.</param>
    /// <returns>The display name if defined; otherwise, the enum value as a string.</returns>
    public static string ToDisplayName<TEnum>(this TEnum enumValue)
        where TEnum : Enum
    {
        var member = typeof(TEnum).GetMember(enumValue.ToString()).FirstOrDefault();
        var displayAttr = member?.GetCustomAttribute<DisplayAttribute>();
        return displayAttr?.Name ?? enumValue.ToString();
    }

    /// <summary>
    /// Attempts to parse a display name to its corresponding enum value.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <param name="displayName">The display name to parse.</param>
    /// <param name="result">When this method returns, contains the enum value if the parse succeeded, or the default value if it failed.</param>
    /// <returns><c>true</c> if the display name was successfully parsed to an enum value; otherwise, <c>false</c>.</returns>
    public static bool TryParseDisplayName<TEnum>(string displayName, out TEnum result)
        where TEnum : struct, Enum
    {
        foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var displayAttr = field.GetCustomAttribute<DisplayAttribute>();
            if (string.Equals(displayAttr?.Name, displayName, StringComparison.OrdinalIgnoreCase))
            {
                result = (TEnum)field.GetValue(null) !;
                return true;
            }
        }

        result = default;
        return false;
    }
}
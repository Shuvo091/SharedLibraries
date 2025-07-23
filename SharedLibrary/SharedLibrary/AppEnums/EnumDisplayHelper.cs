using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SharedLibrary.AppEnums;

public static class EnumDisplayHelper
{
	public static string ToDisplayName<TEnum>(this TEnum enumValue) where TEnum : Enum
	{
		var member = typeof(TEnum).GetMember(enumValue.ToString()).FirstOrDefault();
		var displayAttr = member?.GetCustomAttribute<DisplayAttribute>();
		return displayAttr?.Name ?? enumValue.ToString();
	}

	public static bool TryParseDisplayName<TEnum>(string displayName, out TEnum result) where TEnum : struct, Enum
	{
		foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
		{
			var displayAttr = field.GetCustomAttribute<DisplayAttribute>();
			if (string.Equals(displayAttr?.Name, displayName, StringComparison.OrdinalIgnoreCase))
			{
				result = (TEnum)field.GetValue(null)!;
				return true;
			}
		}

		result = default;
		return false;
	}
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace SharedLibrary.Common.Utilities;

/// <summary>
/// Generic JSON converter for enums that uses display names.
/// </summary>
/// <typeparam name="TEnum">TEnum is a generic enum.</typeparam>
public class EnumConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    /// <summary>
    /// Reads and converts the JSON string representation of a enum to its enum value.
    /// </summary>
    /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
    /// <param name="typeToConvert">The type to convert enum.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    /// <returns>The corresponding enum value.</returns>
    /// Thrown when the JSON value is null, empty, or does not match any display name of properties of the enum.
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();

        if (string.IsNullOrEmpty(value))
        {
            throw new JsonException($"{typeof(TEnum).Name} value cannot be null or empty.");
        }

        return EnumDisplayHelper.TryParseDisplayName<TEnum>(value, out var result) ?
            result :
            throw new JsonException($"Invalid {typeof(TEnum).Name} value: {value}");
    }

    /// <summary>
    /// Writes the enum value as its display name string to JSON.
    /// </summary>
    /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
    /// <param name="value">The enum value to write.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToDisplayName());
    }
}

using System.Text.Json;

namespace SharedLibrary.Common.Utilities;

/// <summary>
/// Extension methods for JSON serialization and deserialization using System.Text.Json.
/// </summary>
public static class JsonExtensions
{
    private static JsonSerializerOptions deserializeOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
    };

    private static JsonSerializerOptions serializeOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
    };

    /// <summary>
    /// Deserializes a JSON string to an object of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type to deserialize to.</typeparam>
    /// <param name="json">The JSON string.</param>
    /// <returns>The deserialized object, or default if input is null or empty.</returns>
    public static T? Deserialize<T>(this string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return default;
        }

        return JsonSerializer.Deserialize<T>(json, deserializeOptions);
    }

    /// <summary>
    /// Serializes an object to a JSON string.
    /// </summary>
    /// <typeparam name="T">The type of the object.</typeparam>
    /// <param name="obj">The object to serialize.</param>
    /// <returns>The JSON string, or null if the object is null.</returns>
    public static string? Serialize<T>(this T? obj)
    {
        if (obj == null)
        {
            return null;
        }

        return JsonSerializer.Serialize(obj, serializeOptions);
    }
}
using System.Text.Json;
using System.Text.Json.Serialization;
using SharedLibrary.AppEnums;
using SharedLibrary.Contracts.QA.Enums;

namespace SharedLibrary.Contracts.QA.JsonConverters;

/// <summary>
/// Provides custom JSON serialization and deserialization logic for <see cref="ParticipantRole"/> values.
/// </summary>
public class ParticipantRoleConverter : JsonConverter<ParticipantRole>
{
    /// <summary>
    /// Reads and converts the JSON data from the specified <see cref="Utf8JsonReader"/> into a <see
    /// cref="ParticipantRole"/> instance.
    /// </summary>
    /// <param name="reader">A reference to the <see cref="Utf8JsonReader"/> positioned at the value to read. The reader will be advanced
    /// past the value if the operation succeeds.</param>
    /// <param name="typeToConvert">The type of the object to convert. This parameter is typically <see cref="ParticipantRole"/> or a derived
    /// type.</param>
    /// <param name="options">Options to control the behavior of the JSON serializer, such as custom converters and naming policies.</param>
    /// <returns>A <see cref="ParticipantRole"/> instance that represents the deserialized value from the JSON data.</returns>
    public override ParticipantRole Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Writes the specified <see cref="ParticipantRole"/> value as JSON using the provided <see
    /// cref="Utf8JsonWriter"/>.
    /// </summary>
    /// <param name="writer">The <see cref="Utf8JsonWriter"/> to which the JSON representation will be written. Cannot be <c>null</c>.</param>
    /// <param name="value">The <see cref="ParticipantRole"/> value to serialize to JSON.</param>
    /// <param name="options">Options to control JSON serialization behavior. May be <c>null</c> to use default settings.</param>
    public override void Write(Utf8JsonWriter writer, ParticipantRole value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToDisplayName());
    }
}

using System.Text.Json.Serialization;

namespace SharedLibrary.Common.ExceptionMiddlewares;

/// <summary>
/// Represents a custom error response model.
/// </summary>
public class CustomErrorResponse
{
    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    public string Message { get; set; } = default!;

    /// <summary>
    /// Gets or sets the call stack of the exception.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DevMessage { get; set; }
}

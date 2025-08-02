using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SharedLibrary.Common.Utilities.HealthCheck;

/// <summary>
/// Provides functionality to write health check responses in JSON format.
/// </summary>
public static class HealthCheckResponseWriter
{
    /// <summary>
    /// Writes a JSON-formatted health report to the HTTP response.
    /// </summary>
    /// <param name="context">The <see cref="HttpContext"/> representing the current HTTP request and response.</param>
    /// <param name="report">The <see cref="HealthReport"/> containing the health check results to be serialized and written to the response.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous operation of writing the response.</returns>
    public static async Task WriteJsonResponse(HttpContext context, HealthReport report)
    {
        context.Response.ContentType = MediaTypeNames.Application.Json;

        var result = new
        {
            status = report.Status.ToString(),
            checks = report.Entries.Select(e => new
            {
                name = e.Key,
                status = e.Value.Status.ToString(),
                description = e.Value.Description ?? string.Empty,
                exception = e.Value.Exception?.Message,
            }),
        };

        await context.Response.WriteAsync(JsonSerializer.Serialize(result));
    }
}

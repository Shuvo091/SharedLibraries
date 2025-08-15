using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog.Context;

namespace SharedLibrary.Common.ExceptionMiddlewares;

/// <summary>
/// Global middleware for capturing unhandled exceptions and logging them.
/// </summary>
public class ExceptionMiddleware
{
    private readonly RequestDelegate next;
    private readonly IHostEnvironment hostingEnvironment;
    private readonly ILogger<ExceptionMiddleware> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExceptionMiddleware"/> class.
    /// </summary>
    /// <param name="next">The next middleware in the pipeline.</param>
    /// <param name="hostingEnvironment">Hosting Environment.</param>
    /// <param name="logger">The logger instance.</param>
    public ExceptionMiddleware(
        RequestDelegate next,
        IHostEnvironment hostingEnvironment,
        ILogger<ExceptionMiddleware> logger)
    {
        this.next = next;
        this.hostingEnvironment = hostingEnvironment;
        this.logger = logger;
    }

    /// <summary>
    /// Invokes the middleware to handle exceptions globally in the application.
    /// </summary>
    /// <param name="context">The HTTP context.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task InvokeAsync(HttpContext context)
    {
        var requestId = context.TraceIdentifier;
        var tenantId = context.Request.Headers.TryGetValue("X-Tenant-ID", out var tid) ? tid.ToString() : "unknown";
        var userId = context.User?.FindFirst("sub")?.Value ?? context.User?.Identity?.Name ?? "anonymous";

        using (LogContext.PushProperty("RequestId", requestId))
        using (LogContext.PushProperty("TenantId", tenantId))
        using (LogContext.PushProperty("UserId", userId))
        using (LogContext.PushProperty("RequestPath", context.Request.Path))
        using (LogContext.PushProperty("HttpMethod", context.Request.Method))
        {
            try
            {
                await this.next(context);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Unhandled exception occurred.");

                var errorResponse = new CustomErrorResponse
                {
                    Message = ex.Message,
                    DevMessage = this.IsDevelopment() ? ex.ToString() : null,
                };

                context.Response.ContentType = MediaTypeNames.Application.Json;
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
            }
        }
    }

    private bool IsDevelopment() => this.hostingEnvironment.IsDevelopment();
}

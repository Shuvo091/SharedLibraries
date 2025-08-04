using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using SharedLibrary.Common.Options;

namespace SharedLibrary.Common.Extensions;

/// <summary>
/// Provides extension methods for configuring services in an <see cref="IServiceCollection"/>.
/// </summary>
/// <remarks>This static class contains methods that extend the functionality of the <see
/// cref="IServiceCollection"/>  interface, allowing for simplified registration and configuration of application
/// services.</remarks>
public static class OpenTelemetryExtensions
{
    /// <summary>
    /// Configures OpenTelemetry metrics for the application and registers the necessary services.
    /// </summary>
    /// <remarks>This method sets up OpenTelemetry metrics with default resource attributes,  adds
    /// instrumentation for ASP.NET Core and HTTP client requests, and configures  a Prometheus exporter for metrics
    /// collection.</remarks>
    /// <param name="services">The <see cref="IServiceCollection"/> to which the OpenTelemetry services will be added.</param>
    /// <param name="configuration">The <see cref="IConfiguration"/> instance containing the application configuration.</param>
    /// <returns>The same <see cref="IServiceCollection"/> instance, allowing for method chaining.</returns>
    public static IServiceCollection RegisterOpenTelemetry(this IServiceCollection services, IConfiguration configuration)
    {
        var otelOptions = configuration.GetSection("OpenTelemetry").Get<OpenTelemetryOptions>()
            ?? throw new InvalidOperationException("Open Telemetry not found.");

        var resourceBuilder = ResourceBuilder.CreateDefault()
            .AddService(serviceName: otelOptions.ServiceName, serviceVersion: otelOptions.ServiceVersion);

        services.AddOpenTelemetry()
            .WithMetrics(metrics =>
            {
                metrics
                    .SetResourceBuilder(resourceBuilder)
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddPrometheusExporter();
            });

        // TODO: Enable Azure Monitor exporter when needed
        // .WithTracing(tracing =>
        // {
        //    tracing
        //        .SetResourceBuilder(resourceBuilder)
        //        .AddAspNetCoreInstrumentation()
        //        .AddHttpClientInstrumentation()
        //        .AddAzureMonitorTraceExporter(options =>
        //        {
        //            options.ConnectionString = otelOptions.AzureApplicationInsightsConnStr;
        //        });
        // });
        return services;
    }
}
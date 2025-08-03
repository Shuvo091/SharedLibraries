using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace SharedLibrary.Common.Extensions;

/// <summary>
/// Extension methog for logging.
/// </summary>
public static class LogExtension
{
    /// <summary>
    /// For serilog.
    /// </summary>
    /// <param name="hostBuilder"> builder.Host from Program. </param>
    public static void AddSerilogLogging(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((context, services, configuration) =>
        {
            var applicationName = context.Configuration.GetValue<string>("Application", "UnknownApp");

            configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentName()
                .Enrich.WithThreadId()
                .Enrich.WithProperty("Application", applicationName)
                .WriteTo.Console()
                .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day);
        });
    }
}

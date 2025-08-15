using SharedLibrary.Contracts.QA.Enums;

namespace SharedLibrary.Contracts.QA.Requests;

/// <summary>
/// Represents a request for platform analytics, including timeframe and dialect filters.
/// </summary>
public class PlatformAnalyticsRequest
{
    /// <summary>
    /// Gets or sets the timeframe for analytics.
    /// </summary>
    public string? TimeFrame { get; set; }

    /// <summary>
    /// Gets or sets the dialect for analytics.
    /// </summary>
    public string? Dialect { get; set; }
}

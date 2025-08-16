namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents a time range with a start and end date.
/// </summary>
public class TimeRangeDto
{
    /// <summary>
    /// Gets or sets the start date of the time range.
    /// </summary>
    required public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the end date of the time range.
    /// </summary>
    required public DateTime EndDate { get; set; }
}

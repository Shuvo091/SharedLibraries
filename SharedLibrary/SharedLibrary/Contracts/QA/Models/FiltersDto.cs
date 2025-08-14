namespace SharedLibrary.Contracts.QA.Models;

/// <summary>
/// Represents filters for batch comparison, such as dialects and comparison types.
/// </summary>
public class FiltersDto
{
    /// <summary>
    /// Gets or sets the list of dialects to filter by.
    /// </summary>
    public List<string> Dialect { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of comparison types to filter by.
    /// </summary>
    public List<string> ComparisonTypes { get; set; } = [];
}

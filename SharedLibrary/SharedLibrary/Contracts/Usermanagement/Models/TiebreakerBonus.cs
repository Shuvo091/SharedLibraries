using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.Models;

/// <summary>
/// Details about a tiebreaker bonus in a three-way comparison.
/// </summary>
public class TiebreakerBonus
{
    /// <summary>
    /// Gets or sets a value indicating whether indicates if the bonus was applied.
    /// </summary>
    public bool Applied { get; set; }

    /// <summary>
    /// Gets or sets amount of the bonus applied.
    /// </summary>
    public int BonusAmount { get; set; }

    /// <summary>
    /// Gets or sets reason for the bonus.
    /// </summary>
    [Required(ErrorMessage = "Reason is required.")]
    [MinLength(1, ErrorMessage = "Reason cannot be empty.")]
    public string Reason { get; set; } = string.Empty;
}
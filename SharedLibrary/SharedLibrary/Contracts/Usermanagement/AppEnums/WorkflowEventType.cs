using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.Usermanagement.AppEnums;

/// <summary>
/// Specifies the type of workflow event.
/// </summary>
public enum WorkflowEventType
{
    /// <summary>
    /// Indicates that the Elo rating was updated.
    /// </summary>
    [Display(Name = "elo_updated")]
    EloUpdated,
}
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums;

public enum WorkflowEventType
{
    [Display(Name = "elo_updated")]
    EloUpdated,
}

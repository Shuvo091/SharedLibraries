using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharedLibrary.Common.Utilities;

namespace SharedLibrary.Contracts.QA.Enums
{
    /// <summary>
    /// Next action to be taken after a comparison.
    /// </summary>
    [JsonConverter(typeof(EnumConverter<NextAction>))]
    public enum NextAction
    {
        /// <summary>
        /// Elo update required in workflow.
        /// </summary>
        [Display(Name = "workflow_elo_update_required")]
        WorkflowEloUpdateRequired,

        /// <summary>
        /// Request third transcriber in workflow.
        /// </summary>
        [Display(Name = "workflow_request_third_transcriber")]
        WorkflowRequestThirdTranscriber,

        /// <summary>
        /// Mark workflow complete with no comparison.
        /// </summary>
        [Display(Name = "workflow_mark_complete_no_comparison")]
        WorkflowMarkCompleteNoComparison,

        /// <summary>
        /// Final Elo update with tiebreaker bonus in workflow.
        /// </summary>
        [Display(Name = "workflow_final_elo_update_with_tiebreaker_bonus")]
        WorkflowFinalEloUpdateWithTiebreakerBonus,
    }
}

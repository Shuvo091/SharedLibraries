using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Contracts.QA.Enums
{
    /// <summary>
    /// Defines the various stages of a comparison process, representing the lifecycle of an item or operation as it
    /// progresses through the system.
    /// </summary>
    public enum ComparisonStage
    {
        /// <summary>
        /// Represents the initial state of an entity or process.
        /// </summary>
        [Display(Name = "initial")]
        Initial,

        /// <summary>
        /// Represents the state of an item that has been enqueued for processing.
        /// </summary>
        [Display(Name = "enqueued")]
        Enqueued,

        /// <summary>
        /// Represents the processing state of an operation.
        /// </summary>
        [Display(Name = "processing")]
        Processing,

        /// <summary>
        /// Represents the AI processing state in the system.
        /// </summary>
        [Display(Name = "openai_analysis")]
        OpenaiAnalysis,

        /// <summary>
        /// Represents the Elo calculation method used for ranking or scoring systems.
        /// </summary>
        [Display(Name = "elo_calculation")]
        EloCalculation,

        /// <summary>
        /// Represents the completed status of an operation or task.
        /// </summary>
        [Display(Name = "completed")]
        Completed,
    }
}

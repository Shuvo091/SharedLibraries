using System.Text.Json.Serialization;
using SharedLibrary.Contracts.QA.Enums;
using SharedLibrary.Contracts.QA.JsonConverters;
using SharedLibrary.Contracts.QA.Models;

namespace SharedLibrary.Contracts.QA.Responses
{
    /// <summary>
    /// Result of a tiebreaker operation.
    /// </summary>
    public class TiebreakerResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether indicates if the tiebreaker was resolved.
        /// </summary>
        required public bool TieBreakerResolved { get; set; }

        /// <summary>
        /// Gets or sets tiebreaker comparison identifier.
        /// </summary>
        required public string TieBreakerComparisonId { get; set; }

        /// <summary>
        /// Gets or sets final winner transcription identifier.
        /// </summary>
        required public string FinalWinner { get; set; }

        /// <summary>
        /// Gets or sets three-way analysis details.
        /// </summary>
        required public TieBreakAnalysis ThreeWayAnalysis { get; set; }

        /// <summary>
        /// Gets or sets list of recommended final Elo changes.
        /// </summary>
        required public List<EloRecommendation> RecommendedFinalEloChanges { get; set; }

        /// <summary>
        /// Gets or sets next action to be taken after tiebreaker.
        /// </summary>
        [JsonConverter(typeof(NextActionConverter))]
        required public NextAction NextAction { get; set; }
    }
}

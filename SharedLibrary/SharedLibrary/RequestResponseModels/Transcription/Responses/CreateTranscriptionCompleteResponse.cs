namespace SharedLibrary.RequestResponseModels.Transcription.Responses
{
    public class CreateTranscriptionCompleteResponse
    {
        public bool? Acknowledged { get; set; }
        public string? WorkflowState { get; set; }
        public int? TranscriptionsReceived { get; set; }
        public int? TranscriptionsNeeded { get; set; }
        public string? NextAction { get; set; }
        public List<TranscriptionCompleteWorkflowStepResponse>? WorkflowSteps { get; set; }
        public DateTime? EstimatedCompletion { get; set; }
    }

    public class TranscriptionCompleteWorkflowStepResponse
    {
        public int? Step { get; set; }
        public string? Action { get; set; }
        public string? Status { get; set; }
        public string? TriggerCondition { get; set; }
    }
}

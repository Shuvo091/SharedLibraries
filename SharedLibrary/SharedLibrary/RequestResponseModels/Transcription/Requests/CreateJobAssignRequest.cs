namespace SharedLibrary.RequestResponseModels.Transcription.Requests
{
    public class CreateJobAssignRequest
    {
        public Guid? WorkflowRequestId { get; set; }
        public Guid UserId { get; set; }
        public Guid ClaimId { get; set; }
        public int? TranscriptionSequence { get; set; }
        public string? AssignedBy { get; set; }
        public string? Notes { get; set; }
    }
}

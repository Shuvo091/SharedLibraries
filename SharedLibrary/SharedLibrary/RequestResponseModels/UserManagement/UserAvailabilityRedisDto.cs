namespace SharedLibrary.RequestResponseModels.UserManagement;


#region Redis DTO

public class UserAvailabilityRedisDto
{
	public string Status { get; set; } = default!;
	public int MaxConcurrentJobs { get; set; } = 3;
	public int CurrentWorkload { get; set; } = 0;
	public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
}

public class UserEloRedisDto
{
	public int CurrentElo { get; set; }
	public int PeakElo { get; set; }
	public int GamesPlayed { get; set; }
	public string RecentTrend { get; set; } = default!;
	public DateTime LastJobCompleted { get; set; }
}

#endregion
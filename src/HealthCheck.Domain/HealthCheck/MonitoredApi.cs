namespace HealthCheck.Domain.HealthCheck;

public class MonitoredApi
{
    public string Hash { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
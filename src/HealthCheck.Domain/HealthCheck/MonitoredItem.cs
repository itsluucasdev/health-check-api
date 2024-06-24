namespace HealthCheck.Domain.HealthCheck;

public class MonitoredItem
{
    public string Hash { get; set; }
    public string Schema { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Endpoint { get; set; }
    public string HttpMethod { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int AuthenticationType { get; set; }
    public int? LastStatus { get; set; }
    public DateTime? LastRun { get; set; }
    
}
using HealthCheck.Domain.Enums;

namespace HealthCheck.Application.HealthCheck.DTO;

public class MonitoredItemDTO
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Endpoint { get; set; }
    public HttpMethod? Method { get; set; }
    public string? User { get; set; }
    public int? Periodicity { get; set; }
    public int[]? DaysOfWeek { get; set; }
    public AuthenticationTypeEnum AuthenticationType { get; set; }
}
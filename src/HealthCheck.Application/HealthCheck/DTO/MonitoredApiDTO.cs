using System.Net;

namespace HealthCheck.Application.HealthCheck.DTO;

public class MonitoredApiDTO
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }
    public HttpMethod? HttpMethod { get; set; }
    public HttpStatusCode ExpectedCode { get; set; }
    public string? ExpectedMessage { get; set; }
}
using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public class HealthCheckService : IHealthCheckService
{
    public MonitoredApi CreateMonitoredApi(MonitoredApiDTO monitoredApiDTO)
    {
        Console.WriteLine($"Start {nameof(HealthCheckService)}.{nameof(CreateMonitoredApi)}");

        var monitoredApi = new MonitoredApi
        {
            Hash = Guid.NewGuid().ToString(),
            Name = monitoredApiDTO.Name,
            Description = monitoredApiDTO.Description,
            Url = monitoredApiDTO.Url,
            HttpMethod = monitoredApiDTO.HttpMethod,
            ExpectedCode = monitoredApiDTO.ExpectedCode,
            ExpectedMessage = monitoredApiDTO.ExpectedMessage,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        return monitoredApi;
    }

    public Task<MonitoredApi> GetMonitoredApi(string hash)
    {
        throw new NotImplementedException();
    }

    public Task<MonitoredApi> GetMonitoredApi()
    {
        throw new NotImplementedException();
    }
}
using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public class HealthCheckService : IHealthCheckService
{
    public MonitoredItem CreateMonitoredApi(MonitoredItemDTO monitoredItemDTO)
    {
        Console.WriteLine($"Start {nameof(HealthCheckService)}.{nameof(CreateMonitoredApi)}");

        var monitoredApi = new MonitoredItem
        {
            Hash = Guid.NewGuid().ToString(),
            Name = monitoredItemDTO.Name,
            Description = monitoredItemDTO.Description,
            HttpMethod = monitoredItemDTO.Method?.ToString(),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        return monitoredApi;
    }

    public Task<MonitoredItem> GetMonitoredApi(string hash)
    {
        throw new NotImplementedException();
    }

    public Task<MonitoredItem> GetMonitoredApi()
    {
        throw new NotImplementedException();
    }
}
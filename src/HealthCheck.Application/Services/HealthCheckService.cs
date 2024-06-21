using HealthCheck.Application.HealthCheck;
using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Application.Interfaces;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.Services;

public class HealthCheckService(IMonitoredItemService monitoredItemService) : IHealthCheckService
{
    public MonitoredItem CreateMonitoredApi(MonitoredItemDTO dto)
    {
        Console.WriteLine($"Start {nameof(HealthCheckService)}.{nameof(CreateMonitoredApi)}");
        
        var monitoredApi = monitoredItemService.CreateMonitoredItemFromDTO(dto);

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
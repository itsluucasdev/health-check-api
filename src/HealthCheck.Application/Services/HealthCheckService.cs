using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Application.Interfaces;
using HealthCheck.Domain.HealthCheck;
using Microsoft.Extensions.Logging;

namespace HealthCheck.Application.Services;

public class HealthCheckService(
    ILogger<HealthCheckService> logger,
    IMonitoredItemService monitoredItemService)
    : IHealthCheckService
{
    private readonly ILogger _logger = logger;

    public MonitoredItem CreateMonitoredApi(MonitoredItemDTO monitoredItemDTO)
    {
        _logger.LogInformation($"{nameof(HealthCheckService)}.{nameof(CreateMonitoredApi)}");
        
        var monitoredApi = monitoredItemService.CreateItemFrom(monitoredItemDTO);

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
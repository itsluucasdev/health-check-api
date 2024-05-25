using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public interface IHealthCheckService
{
    MonitoredApi CreateMonitoredApi(MonitoredApiDTO monitoredApiDTO);
    Task<MonitoredApi> GetMonitoredApi(string hash);
    Task<MonitoredApi> GetMonitoredApi();
}
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public interface IHealthCheckService
{
    Task<MonitoredApi> CreateMonitoredApi();
    Task<MonitoredApi> GetMonitoredApi(string hash);
    Task<MonitoredApi> GetMonitoredApi();
}
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public class HealthCheckService : IHealthCheckService
{
    public Task<MonitoredApi> CreateMonitoredApi()
    {
        throw new NotImplementedException();
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
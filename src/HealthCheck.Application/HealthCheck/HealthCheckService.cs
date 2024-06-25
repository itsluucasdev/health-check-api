using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public class HealthCheckService : IHealthCheckService
{
    public MonitoredItem CreateMonitoredApi(MonitoredItemDTO monitoredItemDTO)
    {
        Console.WriteLine($"Start {nameof(HealthCheckService)}.{nameof(CreateMonitoredApi)}");

        var monitoredApi = CreateItemFrom(monitoredItemDTO);

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

    private static MonitoredItem CreateItemFrom(MonitoredItemDTO dto)
        => new()
        {
            Hash = Guid.NewGuid().ToString(),
            Schema = "API",
            Name = dto.Name,
            Description = dto.Description,
            Endpoint = dto.Endpoint,
            HttpMethod = dto.HttpMethod.ToString(),
            CreatedBy = dto.User,
            CreatedAt = DateTime.Now,
            AuthenticationType = (int)dto.AuthenticationType,
        };
}
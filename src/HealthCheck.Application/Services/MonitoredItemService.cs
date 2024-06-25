using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Application.Interfaces;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.Services;

public class MonitoredItemService : IMonitoredItemService
{
    public MonitoredItem CreateItemFrom(MonitoredItemDTO dto)
        => new()
        {
            Hash = Guid.NewGuid().ToString(),
            Name = dto.Name,
            Description = dto.Description,
            HttpMethod = dto.HttpMethod?.ToString(),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
}
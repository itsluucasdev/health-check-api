using HealthCheck.Application.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.Interfaces;

public interface IMonitoredItemService
{
    MonitoredItem CreateItemFrom(MonitoredItemDTO dto);
}
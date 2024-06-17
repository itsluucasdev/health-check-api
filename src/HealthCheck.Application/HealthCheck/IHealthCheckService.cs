﻿using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.HealthCheck;

public interface IHealthCheckService
{
    MonitoredItem CreateMonitoredApi(MonitoredItemDTO monitoredItemDTO);
    Task<MonitoredItem> GetMonitoredApi(string hash);
    Task<MonitoredItem> GetMonitoredApi();
}
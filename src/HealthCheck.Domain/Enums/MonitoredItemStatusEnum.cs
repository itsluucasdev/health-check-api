using System.ComponentModel;

namespace HealthCheck.Domain.Enums;

public enum MonitoredItemStatusEnum
{
    [Description("OFF-Line")]
    OffLine = 0,

    [Description("ON-Line")]
    OnLine = 1
}